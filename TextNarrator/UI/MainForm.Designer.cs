
namespace TextNarrator.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( ) {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox_TextToRead = new System.Windows.Forms.RichTextBox();
            this.comboBox_Voices = new System.Windows.Forms.ComboBox();
            this.label_SelectVoice = new System.Windows.Forms.Label();
            this.label_TextToRead = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Speak = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.tsmi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_File_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_File_PrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools_Customize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.trackBar_Speed = new System.Windows.Forms.TrackBar();
            this.label_Volume = new System.Windows.Forms.Label();
            this.label_Speed = new System.Windows.Forms.Label();
            this.panel_VoiceInfo = new System.Windows.Forms.Panel();
            this.label_Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Culture = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Name_TXT = new System.Windows.Forms.Label();
            this.label_Culture_TXT = new System.Windows.Forms.Label();
            this.label_Description_TXT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).BeginInit();
            this.panel_VoiceInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_TextToRead
            // 
            this.richTextBox_TextToRead.Location = new System.Drawing.Point(12, 235);
            this.richTextBox_TextToRead.Name = "richTextBox_TextToRead";
            this.richTextBox_TextToRead.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_TextToRead.Size = new System.Drawing.Size(760, 269);
            this.richTextBox_TextToRead.TabIndex = 0;
            this.richTextBox_TextToRead.Text = "";
            // 
            // comboBox_Voices
            // 
            this.comboBox_Voices.FormattingEnabled = true;
            this.comboBox_Voices.Location = new System.Drawing.Point(12, 54);
            this.comboBox_Voices.Name = "comboBox_Voices";
            this.comboBox_Voices.Size = new System.Drawing.Size(244, 21);
            this.comboBox_Voices.TabIndex = 1;
            this.comboBox_Voices.SelectedIndexChanged += new System.EventHandler(this.OnVoiceChanged);
            // 
            // label_SelectVoice
            // 
            this.label_SelectVoice.AutoSize = true;
            this.label_SelectVoice.Location = new System.Drawing.Point(9, 38);
            this.label_SelectVoice.Name = "label_SelectVoice";
            this.label_SelectVoice.Size = new System.Drawing.Size(70, 13);
            this.label_SelectVoice.TabIndex = 2;
            this.label_SelectVoice.Text = "Select Voice:";
            // 
            // label_TextToRead
            // 
            this.label_TextToRead.AutoSize = true;
            this.label_TextToRead.Location = new System.Drawing.Point(12, 219);
            this.label_TextToRead.Name = "label_TextToRead";
            this.label_TextToRead.Size = new System.Drawing.Size(76, 13);
            this.label_TextToRead.TabIndex = 3;
            this.label_TextToRead.Text = "Text to read ...";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_Speed);
            this.panel1.Controls.Add(this.trackBar_Volume);
            this.panel1.Controls.Add(this.trackBar_Speed);
            this.panel1.Controls.Add(this.label_Volume);
            this.panel1.Location = new System.Drawing.Point(479, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 108);
            this.panel1.TabIndex = 4;
            // 
            // btn_Speak
            // 
            this.btn_Speak.Location = new System.Drawing.Point(616, 510);
            this.btn_Speak.Name = "btn_Speak";
            this.btn_Speak.Size = new System.Drawing.Size(156, 23);
            this.btn_Speak.TabIndex = 5;
            this.btn_Speak.Text = "Speak";
            this.btn_Speak.UseVisualStyleBackColor = true;
            this.btn_Speak.Click += new System.EventHandler(this.OnSpeakButtonClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(12, 510);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(156, 23);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.OnClearButtonClick);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File,
            this.tsmi_Edit,
            this.tsmi_Tools,
            this.tsmi_Help});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(784, 24);
            this.menuStrip_Main.TabIndex = 7;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // tsmi_File
            // 
            this.tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File_New,
            this.tsmi_File_Open,
            this.toolStripSeparator,
            this.tsmi_File_Save,
            this.tsmi_File_SaveAs,
            this.toolStripSeparator1,
            this.tsmi_File_Print,
            this.tsmi_File_PrintPreview,
            this.toolStripSeparator2,
            this.tsmi_File_Exit});
            this.tsmi_File.Name = "tsmi_File";
            this.tsmi_File.Size = new System.Drawing.Size(37, 20);
            this.tsmi_File.Text = "&File";
            // 
            // tsmi_File_New
            // 
            this.tsmi_File_New.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_File_New.Image")));
            this.tsmi_File_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_File_New.Name = "tsmi_File_New";
            this.tsmi_File_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_File_New.Size = new System.Drawing.Size(180, 22);
            this.tsmi_File_New.Text = "&New";
            // 
            // tsmi_File_Open
            // 
            this.tsmi_File_Open.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_File_Open.Image")));
            this.tsmi_File_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_File_Open.Name = "tsmi_File_Open";
            this.tsmi_File_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmi_File_Open.Size = new System.Drawing.Size(180, 22);
            this.tsmi_File_Open.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_File_Save
            // 
            this.tsmi_File_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_File_Save.Image")));
            this.tsmi_File_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_File_Save.Name = "tsmi_File_Save";
            this.tsmi_File_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_File_Save.Size = new System.Drawing.Size(180, 22);
            this.tsmi_File_Save.Text = "&Save";
            // 
            // tsmi_File_SaveAs
            // 
            this.tsmi_File_SaveAs.Name = "tsmi_File_SaveAs";
            this.tsmi_File_SaveAs.Size = new System.Drawing.Size(180, 22);
            this.tsmi_File_SaveAs.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_File_Print
            // 
            this.tsmi_File_Print.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_File_Print.Image")));
            this.tsmi_File_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_File_Print.Name = "tsmi_File_Print";
            this.tsmi_File_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmi_File_Print.Size = new System.Drawing.Size(180, 22);
            this.tsmi_File_Print.Text = "&Print";
            // 
            // tsmi_File_PrintPreview
            // 
            this.tsmi_File_PrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_File_PrintPreview.Image")));
            this.tsmi_File_PrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_File_PrintPreview.Name = "tsmi_File_PrintPreview";
            this.tsmi_File_PrintPreview.Size = new System.Drawing.Size(180, 22);
            this.tsmi_File_PrintPreview.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_File_Exit
            // 
            this.tsmi_File_Exit.Name = "tsmi_File_Exit";
            this.tsmi_File_Exit.Size = new System.Drawing.Size(180, 22);
            this.tsmi_File_Exit.Text = "E&xit";
            // 
            // tsmi_Edit
            // 
            this.tsmi_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Edit_Undo,
            this.tsmi_Edit_Redo,
            this.toolStripSeparator3,
            this.tsmi_Edit_Cut,
            this.tsmi_Edit_Copy,
            this.tsmi_Edit_Paste,
            this.toolStripSeparator4,
            this.tsmi_Edit_SelectAll});
            this.tsmi_Edit.Name = "tsmi_Edit";
            this.tsmi_Edit.Size = new System.Drawing.Size(39, 20);
            this.tsmi_Edit.Text = "&Edit";
            // 
            // tsmi_Edit_Undo
            // 
            this.tsmi_Edit_Undo.Name = "tsmi_Edit_Undo";
            this.tsmi_Edit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmi_Edit_Undo.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Edit_Undo.Text = "&Undo";
            this.tsmi_Edit_Undo.Click += new System.EventHandler(this.OnEdit_UndoClick);
            // 
            // tsmi_Edit_Redo
            // 
            this.tsmi_Edit_Redo.Name = "tsmi_Edit_Redo";
            this.tsmi_Edit_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmi_Edit_Redo.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Edit_Redo.Text = "&Redo";
            this.tsmi_Edit_Redo.Click += new System.EventHandler(this.OnEdit_RedoClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_Edit_Cut
            // 
            this.tsmi_Edit_Cut.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Edit_Cut.Image")));
            this.tsmi_Edit_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_Edit_Cut.Name = "tsmi_Edit_Cut";
            this.tsmi_Edit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmi_Edit_Cut.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Edit_Cut.Text = "Cu&t";
            this.tsmi_Edit_Cut.Click += new System.EventHandler(this.OnEdit_CutClick);
            // 
            // tsmi_Edit_Copy
            // 
            this.tsmi_Edit_Copy.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Edit_Copy.Image")));
            this.tsmi_Edit_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_Edit_Copy.Name = "tsmi_Edit_Copy";
            this.tsmi_Edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmi_Edit_Copy.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Edit_Copy.Text = "&Copy";
            this.tsmi_Edit_Copy.Click += new System.EventHandler(this.OnEdit_CopyClick);
            // 
            // tsmi_Edit_Paste
            // 
            this.tsmi_Edit_Paste.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_Edit_Paste.Image")));
            this.tsmi_Edit_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_Edit_Paste.Name = "tsmi_Edit_Paste";
            this.tsmi_Edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmi_Edit_Paste.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Edit_Paste.Text = "&Paste";
            this.tsmi_Edit_Paste.Click += new System.EventHandler(this.OnEdit_PasteClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_Edit_SelectAll
            // 
            this.tsmi_Edit_SelectAll.Name = "tsmi_Edit_SelectAll";
            this.tsmi_Edit_SelectAll.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Edit_SelectAll.Text = "Select &All";
            this.tsmi_Edit_SelectAll.Click += new System.EventHandler(this.OnEdit_SelectAllClick);
            // 
            // tsmi_Tools
            // 
            this.tsmi_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Tools_Customize,
            this.tsmi_Tools_Options});
            this.tsmi_Tools.Name = "tsmi_Tools";
            this.tsmi_Tools.Size = new System.Drawing.Size(46, 20);
            this.tsmi_Tools.Text = "&Tools";
            // 
            // tsmi_Tools_Customize
            // 
            this.tsmi_Tools_Customize.Name = "tsmi_Tools_Customize";
            this.tsmi_Tools_Customize.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Tools_Customize.Text = "&Customize";
            // 
            // tsmi_Tools_Options
            // 
            this.tsmi_Tools_Options.Name = "tsmi_Tools_Options";
            this.tsmi_Tools_Options.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Tools_Options.Text = "&Options";
            // 
            // tsmi_Help
            // 
            this.tsmi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Help_About});
            this.tsmi_Help.Name = "tsmi_Help";
            this.tsmi_Help.Size = new System.Drawing.Size(44, 20);
            this.tsmi_Help.Text = "&Help";
            // 
            // tsmi_Help_About
            // 
            this.tsmi_Help_About.Name = "tsmi_Help_About";
            this.tsmi_Help_About.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Help_About.Text = "&About...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Location = new System.Drawing.Point(10, 37);
            this.trackBar_Volume.Maximum = 100;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Size = new System.Drawing.Size(128, 45);
            this.trackBar_Volume.SmallChange = 2;
            this.trackBar_Volume.TabIndex = 9;
            this.trackBar_Volume.TickFrequency = 10;
            this.trackBar_Volume.Value = 100;
            // 
            // trackBar_Speed
            // 
            this.trackBar_Speed.Location = new System.Drawing.Point(152, 37);
            this.trackBar_Speed.Minimum = -10;
            this.trackBar_Speed.Name = "trackBar_Speed";
            this.trackBar_Speed.Size = new System.Drawing.Size(128, 45);
            this.trackBar_Speed.TabIndex = 10;
            this.trackBar_Speed.TickFrequency = 2;
            // 
            // label_Volume
            // 
            this.label_Volume.AutoSize = true;
            this.label_Volume.Location = new System.Drawing.Point(7, 19);
            this.label_Volume.Name = "label_Volume";
            this.label_Volume.Size = new System.Drawing.Size(45, 13);
            this.label_Volume.TabIndex = 11;
            this.label_Volume.Text = "Volume:";
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.Location = new System.Drawing.Point(149, 19);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(41, 13);
            this.label_Speed.TabIndex = 12;
            this.label_Speed.Text = "Speed:";
            // 
            // panel_VoiceInfo
            // 
            this.panel_VoiceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_VoiceInfo.Controls.Add(this.tableLayoutPanel1);
            this.panel_VoiceInfo.Location = new System.Drawing.Point(12, 92);
            this.panel_VoiceInfo.Name = "panel_VoiceInfo";
            this.panel_VoiceInfo.Size = new System.Drawing.Size(453, 108);
            this.panel_VoiceInfo.TabIndex = 9;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(3, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(43, 15);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.64045F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.35955F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Description_TXT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Culture, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Description, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Name_TXT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Culture_TXT, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 100);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label_Culture
            // 
            this.label_Culture.AutoSize = true;
            this.label_Culture.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Culture.Location = new System.Drawing.Point(3, 25);
            this.label_Culture.Name = "label_Culture";
            this.label_Culture.Size = new System.Drawing.Size(53, 15);
            this.label_Culture.TabIndex = 1;
            this.label_Culture.Text = "Culture:";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.Location = new System.Drawing.Point(3, 50);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(43, 15);
            this.label_Description.TabIndex = 2;
            this.label_Description.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label_Name_TXT
            // 
            this.label_Name_TXT.AutoSize = true;
            this.label_Name_TXT.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name_TXT.Location = new System.Drawing.Point(126, 0);
            this.label_Name_TXT.Name = "label_Name_TXT";
            this.label_Name_TXT.Size = new System.Drawing.Size(27, 15);
            this.label_Name_TXT.TabIndex = 4;
            this.label_Name_TXT.Text = "-----";
            // 
            // label_Culture_TXT
            // 
            this.label_Culture_TXT.AutoSize = true;
            this.label_Culture_TXT.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Culture_TXT.Location = new System.Drawing.Point(126, 25);
            this.label_Culture_TXT.Name = "label_Culture_TXT";
            this.label_Culture_TXT.Size = new System.Drawing.Size(27, 15);
            this.label_Culture_TXT.TabIndex = 5;
            this.label_Culture_TXT.Text = "-----";
            // 
            // label_Description_TXT
            // 
            this.label_Description_TXT.AutoSize = true;
            this.label_Description_TXT.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description_TXT.Location = new System.Drawing.Point(126, 50);
            this.label_Description_TXT.Name = "label_Description_TXT";
            this.label_Description_TXT.Size = new System.Drawing.Size(27, 15);
            this.label_Description_TXT.TabIndex = 6;
            this.label_Description_TXT.Text = "-----";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "-----";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel_VoiceInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Speak);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_TextToRead);
            this.Controls.Add(this.label_SelectVoice);
            this.Controls.Add(this.comboBox_Voices);
            this.Controls.Add(this.richTextBox_TextToRead);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Text Narrator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).EndInit();
            this.panel_VoiceInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_TextToRead;
        private System.Windows.Forms.ComboBox comboBox_Voices;
        private System.Windows.Forms.Label label_SelectVoice;
        private System.Windows.Forms.Label label_TextToRead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Speak;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File_New;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File_Save;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File_Print;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File_PrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Edit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Edit_Undo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Edit_Redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Edit_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Edit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Tools;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Tools_Customize;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Tools_Options;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Help;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Help_About;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.TrackBar trackBar_Speed;
        private System.Windows.Forms.Label label_Volume;
        private System.Windows.Forms.Panel panel_VoiceInfo;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Culture;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Description_TXT;
        private System.Windows.Forms.Label label_Name_TXT;
        private System.Windows.Forms.Label label_Culture_TXT;
    }
}

