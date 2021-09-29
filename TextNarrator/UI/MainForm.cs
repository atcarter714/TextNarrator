#region Using Directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using TextNarrator.Speech;

//using static System.Net.Mime.MediaTypeNames;
using SynthesizerState = System.Speech.Synthesis.SynthesizerState;
#endregion

namespace TextNarrator.UI
{
    public partial class MainForm : Form {

        public MainForm ( ) {
            InitializeComponent();
        }



        Narrator narrator;

        int prevVoiceIndex = 0;
        bool isExportingFile = false;

        #region Constants & Read-Only Strings
        static readonly string
            _PAUSE_TXT = ACResources.Pause_Button_TXT,
            _SPEAK_TXT = ACResources.Speak_Button_TXT,
            _RESUME_TXT = ACResources.Resume_Button_TXT,
            _STOP_TXT = ACResources.StopCancel_Button_TXT;
        #endregion




        #region Form/Control Overrides

        protected override void OnLoad ( EventArgs e ) {

            if ( narrator == null )
                narrator = new Narrator();

            //! Subscribe to Narrator events :
            narrator.SpeakCompleted += ( s, a ) =>
                { _onNarratorFinishedSpeaking(); };

            narrator.StateChanged += ( s, a ) =>
                { _onNarratorStateChanged(); };

            narrator.SpeakStarted += ( s, a ) =>
                { _onNarratorStartedSpeaking(); };

            narrator.SpeakProgress += ( s, a ) =>
                { _onNarratorSpeechProgress(); };

            narrator.FileExported += ( ) => {
                var reenableUI = new Action( () => { _onExportComplete(); });
                this.Invoke( reenableUI ) ;
                isExportingFile = false;
            };

            base.OnLoad( e );
        }

        protected override void OnShown ( EventArgs e ) {

            _setInitialUIState();

            base.OnShown( e );
        }

        protected override void OnClosing ( CancelEventArgs e ) {

            if ( isExportingFile )
                e.Cancel = true;

            else if ( narrator.isSpeaking )
                narrator.Stop();

            base.OnClosing( e );
        }

        protected override void OnClosed ( EventArgs e ) {

            narrator.Dispose();

            base.OnClosed( e );
        }

        //static readonly int WM_PASTE = 0x0302;
        //protected override void WndProc ( ref Message m ) {

        //    if( m.Msg == WM_PASTE || m.Msg == 0x100 ) {
        //        int i = 10, x = 20, c = i + x;
        //    }

        //    base.WndProc( ref m ); 
        //}

        #endregion



        /// <summary>
        /// Call-back invoked when SpeechSynthesizer state changes
        /// </summary>
        void _onNarratorStateChanged ( ) {

            if ( narrator == null || narrator.IsDisposed || narrator.Disposing ) {

                /* The app is closing, and the SpeechSynthesizer object is gone,
                 * so we cannot access its state or take any actions on it ... 
                 */

                return;
            }

            switch ( narrator.SynthState ) {

                //! Narrator is speaking :
                case  SynthesizerState.Speaking: 
                    {
                        btn_Speak.Text = _PAUSE_TXT;

                        _setStopButtonState( true );
                        _enabledisableUIOptions( false );
                        break;
                    }

                //! Narrator is paused :
                case SynthesizerState.Paused: 
                    {
                        btn_Speak.Text = _RESUME_TXT;
                        break;
                    }

                //! Narrator is ready :
                case SynthesizerState.Ready:
                default: 
                    {
                        btn_Speak.Text = _SPEAK_TXT;

                        _setStopButtonState();
                        _enabledisableUIOptions( true );
                        break;
                    }
            }
        }

        /// <summary>
        /// Callback invoked when speaking begins
        /// </summary>
        void _onNarratorStartedSpeaking ( ) {
            
        }

        /// <summary>
        /// Callback invoked when speaking makes progress
        /// </summary>
        void _onNarratorSpeechProgress ( ) {

        }

        /// <summary>
        /// Callback invoked when speaking is finished
        /// </summary>
        void _onNarratorFinishedSpeaking ( ) {

        }



        /// <summary>
        /// Set up the initial UI state when app loads
        /// </summary>
        void _setInitialUIState ( ) {

            OnVoiceChanged( null, null );

            btn_Clear.Text = ACResources.Clear_Button_TXT;
            btn_Speak.Text = ACResources.Speak_Button_TXT;
            btn_Stop.Text = ACResources.StopCancel_Button_TXT;

            _setStopButtonState( false );
        }

        /// <summary>
        /// Enables or disables the voice selector and speech options
        /// </summary>
        /// <param name="enabled">Enabled is set to this value</param>
        void _enabledisableUIOptions ( bool enabled = false ) {
            comboBox_Voices.Enabled = enabled;
            trackBar_Volume.Enabled = enabled;
            trackBar_Speed.Enabled = enabled;
        }

        /// <summary>
        /// Enables of disables the Stop / Cancel button
        /// </summary>
        /// <param name="visibility">Sets visible and enabled to this value</param>
        void _setStopButtonState ( bool visibility = false ) {
            btn_Stop.Enabled = visibility;
            btn_Stop.Visible = visibility;
        }



        void _startSpeaking ( ) {
            narrator.Speak( textBox_NarrationPrompt.Text );
        }

        void _pauseSpeaking ( ) {
            narrator.Pause();
        }

        void _resumeSpeaking ( ) {
            narrator.Resume();
        }

        void _exportFileOK ( object sender, CancelEventArgs e ) {

            /* Anything that needs to be done here when the save
             * file dialog completes without any issues goes here
             */
        }

        void _onSavingWavFile ( ) {

            isExportingFile = true;

            this.UseWaitCursor = true;
            btn_Speak.Enabled = false;
            btn_Clear.Enabled = false;
            btn_Export.Enabled = false;

            _setStopButtonState( false );
            _enabledisableUIOptions( false );
        }

        void _onExportComplete ( ) {

            this.UseWaitCursor = false;
            btn_Speak.Enabled = true;
            btn_Clear.Enabled = true;
            btn_Export.Enabled = true;

            _setStopButtonState( false );
            _enabledisableUIOptions( true );
        }


        #region UI Event Handlers

        void OnVoiceChanged ( object sender, EventArgs e ) {

            if ( narrator != null ) {

                try {

                    //! Swap narrator voices :
                    int index = comboBox_Voices.SelectedIndex;
                    var voiceInfo = narrator.ChangeVoice( index );

                    //! Display the voice info :
                    label_Name_TXT.Text = voiceInfo.Name;
                    label_Culture_TXT.Text = voiceInfo.Culture.DisplayName;
                    label_Gender_TXT.Text = voiceInfo.Gender.ToString();
                    label_Age_TXT.Text = voiceInfo.Age.ToString();

                    prevVoiceIndex = comboBox_Voices.SelectedIndex;
                }

                catch ( Exception ex ) {

                    MessageBox.Show( 
                        $"Cannot use the voice you selected!\n{ex.Message}", 
                        $"Voice Error: HRESULT = {ex.HResult}" );

                    comboBox_Voices.SelectedIndex = prevVoiceIndex;
                }
            }
        }

        void OnSpeakButtonClick( object sender, EventArgs e ) {

            switch ( narrator.SynthState ) {

                case System.Speech.Synthesis.SynthesizerState.Speaking:
                    _pauseSpeaking();
                    break;

                case System.Speech.Synthesis.SynthesizerState.Paused:
                    _resumeSpeaking();
                    break;

                case SynthesizerState.Ready:
                default:
                    _startSpeaking();
                    break;
            }
        }

        void OnStopButtonClick( object sender, EventArgs e ) {
            narrator.Stop();
        }

        void OnClearButtonClick( object sender, EventArgs e ) {
            textBox_NarrationPrompt.Clear();
        }

        void OnVolumeChanged( object sender, EventArgs e ) {

            var vol = trackBar_Volume.Value;

            narrator.Volume = vol;
            label_Volume_Value.Text = vol.ToString();
        }

        void OnSpeedChanged( object sender, EventArgs e ) {

            var speed = trackBar_Speed.Value;

            narrator.Rate = speed;
            label_Speed_Value.Text = speed.ToString();
        }

        void OnSaveToAudioFile( object sender, EventArgs e ) {

            if ( narrator == null || narrator.IsDisposed || narrator.Disposing )
                return;

            else if ( narrator.SynthState != SynthesizerState.Ready )
                narrator.Stop();

            using ( SaveFileDialog saveDialog = new SaveFileDialog() {
                    OverwritePrompt = true,
                    CheckPathExists = true,
                    DefaultExt = ".wav",
                    Filter = "Wav Files | *.wav",
                    FileName = "narrator_export.wav",
                    AddExtension = true,
                } ) {

                saveDialog.FileOk += ( s, cancel_args ) => {

                    var filename = saveDialog.FileName;
                    narrator.ExportAudio( filename, textBox_NarrationPrompt.Text );
                };

                
                saveDialog.ShowDialog();
                _onSavingWavFile();

                saveDialog.Dispose();
            }
        }

        #endregion

        #region Edit Menu Items

        //void OnEdit_UndoClick ( object sender, EventArgs e ) {

        //    if ( textBox_NarrationPrompt.CanUndo )
        //        textBox_NarrationPrompt.Undo();
        //}

        //void OnEdit_RedoClick ( object sender, EventArgs e ) {

        //    if ( textBox_NarrationPrompt.CanRedo )
        //        textBox_NarrationPrompt.Redo();
        //}

        void OnEdit_CutClick ( object sender, EventArgs e ) {

            if ( textBox_NarrationPrompt.SelectedText.Length > 0 )
                textBox_NarrationPrompt.Cut();
        }

        void OnEdit_CopyClick ( object sender, EventArgs e ) {

            if ( textBox_NarrationPrompt.SelectedText.Length > 0 )
                textBox_NarrationPrompt.Copy();
        }

        void OnEdit_PasteClick ( object sender, EventArgs e ) {

            if ( Clipboard.ContainsText() ) {

                //textBox_NarrationPrompt.Paste();

                var copiedText = Clipboard.GetText();
                textBox_NarrationPrompt.Text += copiedText;
            }

        }

        void OnEdit_SelectAllClick ( object sender, EventArgs e ) {

            if ( textBox_NarrationPrompt.Text.Length > 0 )
                textBox_NarrationPrompt.SelectAll();
        }

        void OnEdit_DeleteClick ( object sender, EventArgs e ) {

            //var selection = textBox_NarrationPrompt.SelectedText;

            textBox_NarrationPrompt.SelectedText = string.Empty;
        }

        #endregion

        //void OnTextboxRightClick ( object sender, MouseEventArgs e ) {

        //    if ( e.Button == MouseButtons.Right ) {

        //        if ( contextMenuStrip_EditText.Visible )
        //            contextMenuStrip_EditText.Hide();

        //        _onOpeningContext( ( textBox_NarrationPrompt.SelectedText.Length > 0 ) );

        //        contextMenuStrip_EditText.Show( textBox_NarrationPrompt, e.Location );
        //    }


        //    void _onOpeningContext ( bool hasSelectedText ) {

        //        contextMenu_Copy.Enabled = hasSelectedText;
        //        contextMenu_Cut.Enabled = hasSelectedText;
        //        contextMenu_Delete.Enabled = hasSelectedText;
        //    }
        //}

        

        public void AddVoices ( string[] names ) {

            if ( names == null || names.Length == 0 )
                throw new ArgumentException(
                    "MainForm.AddVoices(string[]): Argument is null or empty!", "names" );

            foreach ( string name in names ) {
                comboBox_Voices.Items.Add( name );
            }

            comboBox_Voices.SelectedIndex = 0;
        }

    }
}



//if ( narrator.isSpeaking ) {

//    var waitThread = new Thread( ( ) =>
//    {
//        while( narrator.isSpeaking )
//            Thread.Sleep( 100 );

//        narrator.ChangeVoice( index );
//    });

//    waitThread.Start();
//}
//else


//public void AddVoice( string name ) {

//    if ( string.IsNullOrEmpty( name ) )
//        throw new ArgumentException( 
//            $"MainForm.AddVoice(string): Parameter is null or empty!", "name" );

//    else
//        comboBox_Voices.Items.Add( name );
//}


//! MULTI-THREADED WAIT FOR COMPLETE:

//_setStopButtonState( true );
//btn_Stop.Click += OnStopButtonClick;

/* Create a thread that waits for speech to finish and once complete
 * it will hide the Stop button and disable it again 
 */
//var waitThr = new Thread( ( ) =>
//{

//    while( narrator.isSpeaking || narrator.isPaused )
//        Thread.Sleep ( 100 );

//    if( this != null && ( !this.Disposing && !this.IsDisposed ) ) {

//        Action hideStopBtn2 = ( ) =>
//        {
//            _setStopButtonState( );
//            btn_Stop.Click -= OnStopButtonClick;
//        };

//        this.Invoke( hideStopBtn2 );
//    }
//} );

//waitThr.Start();