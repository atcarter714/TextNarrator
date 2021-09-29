#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Speech.Synthesis;
using System.Xml.Linq;
#endregion

namespace TextNarrator.Speech
{
    public class Narrator : IDisposable
    {
        public Narrator ( ) {

            _initEngine();
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Narrator()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }



        #region Constants

        const int
            _MIN_VOL    = 0,
            _MAX_VOL    = 100,
            _MIN_RATE   = -10,
            _MAX_RATE   = 10;

        /// <summary>
        /// HRESULT Error code:
        /// Occurs when asynchronous speech is canceled
        /// during the middle of speaking
        /// </summary>
        const int _HRESULT_ASYNC_CANCEL = -2146233029;

        /// <summary>
        /// Default audio export path
        /// </summary>
        static readonly string _DEFAULT_EXPORT_PATH =
            $"{Environment.CurrentDirectory}\\exports\\";

        #endregion



        protected bool disposed;
        protected SpeechSynthesizer speechSynth;
        protected ReadOnlyCollection<InstalledVoice> installedVoices;


        #region Public Properties

        /// <summary>
        /// Indicates if Narrator has disposed of resources
        /// </summary>
        public bool IsDisposed => disposed;

        /// <summary>
        /// Indicates if Narrator is disposing of resources
        /// </summary>
        public bool Disposing { get; protected set; }



        /// <summary>
        /// Gets or sets the Narrator's speed
        /// </summary>
        public int Rate {
            
            get { return speechSynth.Rate; }

            set {

                int newRate = value;

                if ( newRate < _MIN_RATE )
                    newRate = _MIN_RATE;
                else if ( newRate > _MAX_RATE )
                    newRate = _MAX_RATE;

                speechSynth.Rate = newRate; 
            }
        }

        /// <summary>
        /// Gets or sets the Narrator's volume
        /// </summary>
        public int Volume {

            get { return speechSynth.Volume; }

            set {

                int newVolume = value;

                if ( newVolume < _MIN_VOL )
                    newVolume = _MIN_VOL;
                else if ( newVolume > _MAX_VOL )
                    newVolume = _MAX_VOL;

                speechSynth.Volume = newVolume; 
            }
        }



        /// <summary>
        /// Indicates if the Narrator is speaking
        /// </summary>
        public bool isSpeaking =>
            speechSynth.State == SynthesizerState.Speaking;

        /// <summary>
        /// Indicates if the narrator paused during speaking
        /// </summary>
        public bool isPaused =>
            speechSynth.State == SynthesizerState.Paused;

        /// <summary>
        /// Indicates if the Narrator is ready to speak
        /// </summary>
        public bool isReady =>
            speechSynth.State == SynthesizerState.Ready;

        /// <summary>
        /// Gets the state enum of the SpeechSynthesizer
        /// </summary>
        public SynthesizerState SynthState =>
            speechSynth.State;

        #endregion

        #region Narrator Events

        object objLock = new object();
        event EventHandler<StateChangedEventArgs> stateChanged;
        event EventHandler<SpeakCompletedEventArgs> speakCompleted;
        event EventHandler<SpeakStartedEventArgs> speakStarted;
        event EventHandler<SpeakProgressEventArgs> speakProgress;
        event Action fileExported;

        /// <summary>
        /// Event raised on speech synthesis state changes
        /// </summary>
        public event EventHandler<StateChangedEventArgs> StateChanged {

            add {
                lock ( objLock ) {
                    stateChanged += value;
                }
            }

            remove {
                lock ( objLock ) {
                    stateChanged -= value;
                }
            }
        }

        /// <summary>
        /// Event raised when speech synthesis begins
        /// </summary>
        public event EventHandler<SpeakStartedEventArgs> SpeakStarted {

            add {
                lock ( objLock ) {
                    speakStarted += value;
                }
            }

            remove {
                lock ( objLock ) {
                    speakStarted -= value;
                }
            }
        }

        /// <summary>
        /// Event raised when speech synthesis completes
        /// </summary>
        public event EventHandler<SpeakCompletedEventArgs> SpeakCompleted {

            add {
                lock ( objLock ) {
                    speakCompleted += value;
                }
            }

            remove {
                lock ( objLock ) {
                    speakCompleted -= value;
                }
            }
        }

        /// <summary>
        /// Event raised when speech synthesis progresses
        /// </summary>
        public event EventHandler<SpeakProgressEventArgs> SpeakProgress {

            add {
                lock ( objLock ) {
                    speakProgress += value;
                }
            }

            remove {
                lock ( objLock ) {
                    speakProgress -= value;
                }
            }
        }

        /// <summary>
        /// Event raised when a wav file is finished exporting
        /// </summary>
        public event Action FileExported {

            add {
                lock ( objLock ) {
                    fileExported += value;
                }
            }

            remove {
                lock ( objLock ) {
                    fileExported -= value;
                }
            }
        }

        #endregion



        void _initEngine ( ) {

            speechSynth = new SpeechSynthesizer();
            installedVoices = speechSynth.GetInstalledVoices();

            var names = new string[installedVoices.Count];
            for ( int i = 0; i < names.Length; i++ ) {
                names[i] = installedVoices[i].VoiceInfo.Name;
            }
            
            Program.MainForm.AddVoices( names );

            //! Subscribe to Speech events :
            speechSynth.SpeakCompleted += onSpeechComplete;
            speechSynth.SpeakProgress += onSpeechProgress;
            speechSynth.SpeakStarted += onSpeechBegin;
            speechSynth.StateChanged += onStateChange;
        }


        /// <summary>
        /// Speaks the given text through  a 
        /// SpeechSynthesizer object asynchronously
        /// </summary>
        /// <param name="text">Text to speak</param>
        public void Speak( string text ) {

            if ( string.IsNullOrEmpty( text ) )
                return;

            if( speechSynth.State == SynthesizerState.Ready )
                speechSynth.SpeakAsync( text );
        }

        /// <summary>
        /// Pauses the SpeechSynthesizer during speech
        /// </summary>
        public void Pause ( ) {

            if ( speechSynth.State == SynthesizerState.Speaking )
                speechSynth.Pause();
        }

        /// <summary>
        /// Resumes the SpeechSynthesizer if paused
        /// </summary>
        public void Resume ( ) {

            if ( speechSynth.State == SynthesizerState.Paused )
                speechSynth.Resume();
        }

        /// <summary>
        /// Stops the SpeechSynthesizer if speaking or paused
        /// </summary>
        public void Stop ( ) {

            if ( this.isSpeaking || this.isPaused ) {

                if ( this.isPaused )
                    speechSynth.Resume();

                speechSynth.SpeakAsyncCancelAll();
            }
        }

        /// <summary>
        /// Changes to a new installed voice
        /// </summary>
        /// <param name="index">Index of the voice selected</param>
        /// <returns>Information about the voice</returns>
        public VoiceInfo ChangeVoice( int index ) {

            if ( index < 0 || index >= installedVoices.Count )
                throw new IndexOutOfRangeException( 
                    $"Narrator.ChangeVoice({index}): Index out of range!" );

            speechSynth.SelectVoice( installedVoices[index].VoiceInfo.Name );
            
            return installedVoices[index].VoiceInfo;
        }

        /// <summary>
        /// Creates a wav file of the Narrator's voice reading
        /// the given text and saves it to disk ...
        /// </summary>
        /// <param name="fullPath">Path to save the file</param>
        /// <param name="textToSpeak">Text to speak aloud and save to audio file</param>
        public void ExportAudio ( string fullPath, string textToSpeak ) {

            //! Stop any speech currently playing/paused :
            if ( SynthState != SynthesizerState.Ready )
                Stop();

            //! Set output to wav file and speak :
            speechSynth.SetOutputToWaveFile( fullPath );
            this.Speak( textToSpeak );

            //! Wait on a separate thread for speech to finish :
            var waitThread = new Thread( () =>
            {

                while ( SynthState == SynthesizerState.Speaking )
                    Thread.Sleep(50);

                //! Restore output to default audio device :
                speechSynth.SetOutputToDefaultAudioDevice();

                //! Fire export completed event to the UI :
                if(fileExported != null) {
                    fileExported();
                }

            } ) {
                
                Name = "SetDefaultAudioOuput_WAIT_THREAD",
                Priority = ThreadPriority.Normal,
                IsBackground = true,
            };

            waitThread.Start();
            
        }


        #region SpeechSynthesizer Event Handlers

        protected virtual void onStateChange ( object sender, StateChangedEventArgs e ) {

            if ( this.stateChanged != null )
                this.stateChanged( sender, e );
        }

        protected virtual void onSpeechProgress ( object sender, SpeakProgressEventArgs e ) {

            if ( this.speakProgress != null )
                this.speakProgress( sender, e );
        }

        protected virtual void onSpeechComplete ( object sender, SpeakCompletedEventArgs e ) {

            /* If an error occurs other than an operation cancelled result
             * caused by cancelling speech in our Stop method, report the
             * error to the user ...
             */

            if ( e.Error != null )
                if(e.Error.HResult != _HRESULT_ASYNC_CANCEL )
                    System.Windows.Forms.MessageBox.Show(
                        $"A speech error has occurred!\n{e.Error.Message}",
                        $"ERROR: HRESULT = {e.Error.HResult.ToString()}" );

            //! Pass the event thru :
            if ( this.speakCompleted != null )
                this.speakCompleted( sender, e );
        }

        protected virtual void onSpeechBegin ( object sender, SpeakStartedEventArgs e ) {

            if ( this.speakStarted != null )
                this.speakStarted( sender, e );
        }

        #endregion

        #region IDisposable

        protected virtual void Dispose ( bool disposing ) {

            if ( !disposed ) {

                this.Disposing = disposing;

                if ( disposing && speechSynth != null ) {

                    if( this.isSpeaking || this.isPaused )
                        this.Stop();

                    speechSynth.SpeakCompleted -= onSpeechComplete;
                    speechSynth.SpeakProgress -= onSpeechProgress;
                    speechSynth.SpeakStarted -= onSpeechBegin;
                    speechSynth.StateChanged -= onStateChange;

                    speechSynth.Dispose();
                    speechSynth = null;
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposed = true;
            }
        }

        public void Dispose ( ) {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose( disposing: true );
            GC.SuppressFinalize( this );
        }

        #endregion
    }
}