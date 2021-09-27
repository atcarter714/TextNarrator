#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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
        #endregion



        protected int rate, volume;
        protected bool disposed;
        protected SpeechSynthesizer speechSynth;
        protected ReadOnlyCollection<InstalledVoice> installedVoices;


        #region Public Properties

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


        void _initEngine ( ) {

            speechSynth = new SpeechSynthesizer();
            installedVoices = speechSynth.GetInstalledVoices();

            var names = new string[installedVoices.Count];
            for ( int i = 0; i < names.Length; i++ ) {
                names[i] = installedVoices[i].VoiceInfo.Name;
            }
            
            Program.MainForm.AddVoices( names );
        }


        public void Speak( string text ) {

            if ( string.IsNullOrEmpty( text ) )
                return;

            if( speechSynth.State == SynthesizerState.Ready )
                speechSynth.SpeakAsync( text );
        }

        public void Pause ( ) {

            if ( speechSynth.State == SynthesizerState.Speaking )
                speechSynth.Pause();
        }

        public void Resume ( ) {

            if ( speechSynth.State == SynthesizerState.Paused )
                speechSynth.Resume();
        }

        public VoiceInfo ChangeVoice( int index ) {

            if ( index < 0 || index >= installedVoices.Count )
                throw new IndexOutOfRangeException( 
                    $"Narrator.ChangeVoice({index}): Index out of range!" );

            speechSynth.SelectVoice( installedVoices[index].VoiceInfo.Name );
            
            return installedVoices[index].VoiceInfo;
        }



        #region IDisposable

        protected virtual void Dispose ( bool disposing ) {

            if ( !disposed ) {
                if ( disposing ) {
                    speechSynth.Dispose();
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