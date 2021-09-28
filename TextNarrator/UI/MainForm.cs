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

            base.OnLoad( e );
        }

        protected override void OnShown ( EventArgs e ) {

            _setInitialUIState();

            base.OnShown( e );
        }

        protected override void OnClosing ( CancelEventArgs e ) {

            if ( narrator.isSpeaking )
                narrator.Stop();

            base.OnClosing( e );
        }

        protected override void OnClosed ( EventArgs e ) {
            
            narrator.Dispose();

            base.OnClosed( e ); 
        }

        #endregion



        /// <summary>
        /// Call-back invoked when SpeechSynthesizer state changes
        /// </summary>
        void _onNarratorStateChanged ( ) {

            switch ( narrator.SynthState ) {

                case  SynthesizerState.Speaking:

                    btn_Speak.Text = _PAUSE_TXT;

                    _setStopButtonState( true );
                    _enabledisableUIOptions( false );
                    break;

                case SynthesizerState.Paused:

                    btn_Speak.Text = _RESUME_TXT;
                    break;

                case SynthesizerState.Ready:
                default:

                    btn_Speak.Text = _SPEAK_TXT;

                    _setStopButtonState();
                    _enabledisableUIOptions( true );
                    break;
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
            narrator.Speak( richTextBox_TextToRead.Text );
        }

        void _pauseSpeaking ( ) {
            narrator.Pause();
        }

        void _resumeSpeaking ( ) {
            narrator.Resume();
        }



        #region UI Event Handlers

        void OnVoiceChanged ( object sender, EventArgs e ) {

            if ( narrator != null ) {

                //! Swap narrator voices :
                int index = comboBox_Voices.SelectedIndex;
                var voiceInfo = narrator.ChangeVoice( index );

                //! Display the voice info :
                label_Name_TXT.Text = voiceInfo.Name;
                label_Culture_TXT.Text = voiceInfo.Culture.DisplayName;
                label_Gender_TXT.Text = voiceInfo.Gender.ToString();
                label_Age_TXT.Text = voiceInfo.Age.ToString();
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
            richTextBox_TextToRead.Clear();
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

        #endregion



        #region Edit Menu Items

        void OnEdit_UndoClick ( object sender, EventArgs e ) {

            if ( richTextBox_TextToRead.CanUndo )
                richTextBox_TextToRead.Undo();
        }

        void OnEdit_RedoClick ( object sender, EventArgs e ) {

            if ( richTextBox_TextToRead.CanRedo )
                richTextBox_TextToRead.Redo();
        }

        void OnEdit_CutClick ( object sender, EventArgs e ) {

            if ( richTextBox_TextToRead.SelectedText.Length > 0 )
                richTextBox_TextToRead.Cut();
        }

        void OnEdit_CopyClick ( object sender, EventArgs e ) {

            if ( richTextBox_TextToRead.SelectedText.Length > 0 )
                richTextBox_TextToRead.Copy();
        }

        void OnEdit_PasteClick ( object sender, EventArgs e ) {

            if ( Clipboard.ContainsText() && richTextBox_TextToRead.CanPaste( DataFormats.GetFormat( DataFormats.Text ) ) )
                richTextBox_TextToRead.Paste();
        }

        void OnEdit_SelectAllClick ( object sender, EventArgs e ) {

            if ( richTextBox_TextToRead.Text.Length > 0 )
                richTextBox_TextToRead.SelectAll();
        }

        void OnEdit_DeleteClick( object sender, EventArgs e ) {

            //var selection = richTextBox_TextToRead.SelectedText;

            richTextBox_TextToRead.SelectedText = string.Empty;
        }

        #endregion


        void OnTextboxRightClick ( object sender, MouseEventArgs e ) {

            if ( e.Button == MouseButtons.Right ) {

                if ( contextMenuStrip_EditText.Visible )
                    contextMenuStrip_EditText.Hide();

                contextMenuStrip_EditText.Show( richTextBox_TextToRead, e.Location );
            }
        }



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