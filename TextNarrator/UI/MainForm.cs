#region Using Directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using TextNarrator.Speech;
using static System.Net.Mime.MediaTypeNames;
#endregion

namespace TextNarrator.UI
{
    public partial class MainForm : Form
    {
        public MainForm ( ) {
            InitializeComponent();
        }


        
        Narrator narrator;





        protected override void OnShown ( EventArgs e ) {

            if ( narrator == null )
                narrator = new Narrator();

            base.OnShown( e ); 
        }


        void OnVoiceChanged ( object sender, EventArgs e ) {

            if ( narrator != null ) {

                int index = comboBox_Voices.SelectedIndex;

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
                var voiceInfo = narrator.ChangeVoice( index );

                label_Name_TXT.Text = voiceInfo.Name;
                label_Culture_TXT.Text = voiceInfo.Culture.DisplayName;
                
            }
        }

        void OnSpeakButtonClick( object sender, EventArgs e ) {
            narrator.Speak( richTextBox_TextToRead.Text );
        }

        void OnClearButtonClick( object sender, EventArgs e ) {
            richTextBox_TextToRead.Clear();
        }


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

        #endregion



        //public void AddVoice( string name ) {

        //    if ( string.IsNullOrEmpty( name ) )
        //        throw new ArgumentException( 
        //            $"MainForm.AddVoice(string): Parameter is null or empty!", "name" );
            
        //    else
        //        comboBox_Voices.Items.Add( name );
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