
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox_TextToRead = new System.Windows.Forms.RichTextBox();
            this.comboBox_Voices = new System.Windows.Forms.ComboBox();
            this.label_SelectVoice = new System.Windows.Forms.Label();
            this.label_TextToRead = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Speed_Value = new System.Windows.Forms.Label();
            this.label_Volume_Value = new System.Windows.Forms.Label();
            this.label_Speed = new System.Windows.Forms.Label();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.trackBar_Speed = new System.Windows.Forms.TrackBar();
            this.label_Volume = new System.Windows.Forms.Label();
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
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools_Customize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Tools_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.panel_VoiceInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Age_TXT = new System.Windows.Forms.Label();
            this.label_Gender_TXT = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Culture = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_Name_TXT = new System.Windows.Forms.Label();
            this.label_Culture_TXT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip_EditText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenu_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenu_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).BeginInit();
            this.menuStrip_Main.SuspendLayout();
            this.panel_VoiceInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip_EditText.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_TextToRead
            // 
            this.richTextBox_TextToRead.BackColor = System.Drawing.Color.MediumBlue;
            this.richTextBox_TextToRead.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_TextToRead.ForeColor = System.Drawing.Color.White;
            this.richTextBox_TextToRead.Location = new System.Drawing.Point(12, 235);
            this.richTextBox_TextToRead.Name = "richTextBox_TextToRead";
            this.richTextBox_TextToRead.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_TextToRead.Size = new System.Drawing.Size(760, 269);
            this.richTextBox_TextToRead.TabIndex = 0;
            this.richTextBox_TextToRead.Text = "Input text for narrator to read ...";
            this.richTextBox_TextToRead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnTextboxRightClick);
            // 
            // comboBox_Voices
            // 
            this.comboBox_Voices.BackColor = System.Drawing.Color.MediumBlue;
            this.comboBox_Voices.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Voices.ForeColor = System.Drawing.Color.AliceBlue;
            this.comboBox_Voices.FormattingEnabled = true;
            this.comboBox_Voices.Location = new System.Drawing.Point(12, 54);
            this.comboBox_Voices.Name = "comboBox_Voices";
            this.comboBox_Voices.Size = new System.Drawing.Size(244, 24);
            this.comboBox_Voices.TabIndex = 1;
            this.comboBox_Voices.Text = "Select a voice ...";
            this.comboBox_Voices.SelectedIndexChanged += new System.EventHandler(this.OnVoiceChanged);
            // 
            // label_SelectVoice
            // 
            this.label_SelectVoice.AutoSize = true;
            this.label_SelectVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectVoice.ForeColor = System.Drawing.Color.White;
            this.label_SelectVoice.Location = new System.Drawing.Point(9, 35);
            this.label_SelectVoice.Name = "label_SelectVoice";
            this.label_SelectVoice.Size = new System.Drawing.Size(87, 16);
            this.label_SelectVoice.TabIndex = 2;
            this.label_SelectVoice.Text = "Select Voice:";
            // 
            // label_TextToRead
            // 
            this.label_TextToRead.AutoSize = true;
            this.label_TextToRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TextToRead.ForeColor = System.Drawing.Color.White;
            this.label_TextToRead.Location = new System.Drawing.Point(13, 216);
            this.label_TextToRead.Name = "label_TextToRead";
            this.label_TextToRead.Size = new System.Drawing.Size(91, 16);
            this.label_TextToRead.TabIndex = 3;
            this.label_TextToRead.Text = "Text to read ...";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_Speed_Value);
            this.panel1.Controls.Add(this.label_Volume_Value);
            this.panel1.Controls.Add(this.label_Speed);
            this.panel1.Controls.Add(this.trackBar_Volume);
            this.panel1.Controls.Add(this.trackBar_Speed);
            this.panel1.Controls.Add(this.label_Volume);
            this.panel1.Location = new System.Drawing.Point(479, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 108);
            this.panel1.TabIndex = 4;
            // 
            // label_Speed_Value
            // 
            this.label_Speed_Value.AutoSize = true;
            this.label_Speed_Value.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Speed_Value.ForeColor = System.Drawing.Color.White;
            this.label_Speed_Value.Location = new System.Drawing.Point(211, 77);
            this.label_Speed_Value.Name = "label_Speed_Value";
            this.label_Speed_Value.Size = new System.Drawing.Size(15, 15);
            this.label_Speed_Value.TabIndex = 11;
            this.label_Speed_Value.Text = "0";
            // 
            // label_Volume_Value
            // 
            this.label_Volume_Value.AutoSize = true;
            this.label_Volume_Value.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Volume_Value.ForeColor = System.Drawing.Color.White;
            this.label_Volume_Value.Location = new System.Drawing.Point(57, 77);
            this.label_Volume_Value.Name = "label_Volume_Value";
            this.label_Volume_Value.Size = new System.Drawing.Size(31, 15);
            this.label_Volume_Value.TabIndex = 13;
            this.label_Volume_Value.Text = "100";
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Speed.ForeColor = System.Drawing.Color.White;
            this.label_Speed.Location = new System.Drawing.Point(149, 18);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(52, 16);
            this.label_Speed.TabIndex = 12;
            this.label_Speed.Text = "Speed:";
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.BackColor = System.Drawing.Color.MidnightBlue;
            this.trackBar_Volume.Location = new System.Drawing.Point(10, 37);
            this.trackBar_Volume.Maximum = 100;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Size = new System.Drawing.Size(128, 45);
            this.trackBar_Volume.SmallChange = 2;
            this.trackBar_Volume.TabIndex = 9;
            this.trackBar_Volume.TickFrequency = 10;
            this.trackBar_Volume.Value = 100;
            this.trackBar_Volume.ValueChanged += new System.EventHandler(this.OnVolumeChanged);
            // 
            // trackBar_Speed
            // 
            this.trackBar_Speed.BackColor = System.Drawing.Color.MidnightBlue;
            this.trackBar_Speed.Location = new System.Drawing.Point(152, 37);
            this.trackBar_Speed.Minimum = -10;
            this.trackBar_Speed.Name = "trackBar_Speed";
            this.trackBar_Speed.Size = new System.Drawing.Size(128, 45);
            this.trackBar_Speed.TabIndex = 10;
            this.trackBar_Speed.TickFrequency = 2;
            this.trackBar_Speed.ValueChanged += new System.EventHandler(this.OnSpeedChanged);
            // 
            // label_Volume
            // 
            this.label_Volume.AutoSize = true;
            this.label_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Volume.ForeColor = System.Drawing.Color.White;
            this.label_Volume.Location = new System.Drawing.Point(7, 18);
            this.label_Volume.Name = "label_Volume";
            this.label_Volume.Size = new System.Drawing.Size(57, 16);
            this.label_Volume.TabIndex = 11;
            this.label_Volume.Text = "Volume:";
            // 
            // btn_Speak
            // 
            this.btn_Speak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Speak.BackgroundImage")));
            this.btn_Speak.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Speak.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Speak.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Speak.Location = new System.Drawing.Point(616, 510);
            this.btn_Speak.Name = "btn_Speak";
            this.btn_Speak.Size = new System.Drawing.Size(156, 26);
            this.btn_Speak.TabIndex = 5;
            this.btn_Speak.Text = "Speak";
            this.btn_Speak.UseVisualStyleBackColor = true;
            this.btn_Speak.Click += new System.EventHandler(this.OnSpeakButtonClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.AutoEllipsis = true;
            this.btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.BackgroundImage")));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Clear.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Clear.Location = new System.Drawing.Point(12, 510);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(156, 26);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.OnClearButtonClick);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip_Main.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(784, 24);
            this.menuStrip_Main.TabIndex = 7;
            this.menuStrip_Main.Text = "menuStripMain";
            // 
            // tsmi_File
            // 
            this.tsmi_File.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_File.ForeColor = System.Drawing.Color.Black;
            this.tsmi_File.Name = "tsmi_File";
            this.tsmi_File.Size = new System.Drawing.Size(42, 21);
            this.tsmi_File.Text = "&File";
            // 
            // tsmi_File_New
            // 
            this.tsmi_File_New.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsmi_File_New.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_File_New.Image")));
            this.tsmi_File_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_File_New.Name = "tsmi_File_New";
            this.tsmi_File_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_File_New.Size = new System.Drawing.Size(180, 22);
            this.tsmi_File_New.Text = "&New";
            // 
            // tsmi_File_Open
            // 
            this.tsmi_File_Open.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.tsmi_File_Save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsmi_File_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_File_Save.Image")));
            this.tsmi_File_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmi_File_Save.Name = "tsmi_File_Save";
            this.tsmi_File_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_File_Save.Size = new System.Drawing.Size(180, 22);
            this.tsmi_File_Save.Text = "&Save";
            // 
            // tsmi_File_SaveAs
            // 
            this.tsmi_File_SaveAs.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.tsmi_File_Exit.BackColor = System.Drawing.Color.Cornsilk;
            this.tsmi_File_Exit.Name = "tsmi_File_Exit";
            this.tsmi_File_Exit.Size = new System.Drawing.Size(180, 22);
            this.tsmi_File_Exit.Text = "E&xit";
            // 
            // tsmi_Edit
            // 
            this.tsmi_Edit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_Edit.ForeColor = System.Drawing.Color.Black;
            this.tsmi_Edit.Name = "tsmi_Edit";
            this.tsmi_Edit.Size = new System.Drawing.Size(44, 21);
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmi_Tools
            // 
            this.tsmi_Tools.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_Tools.ForeColor = System.Drawing.Color.Black;
            this.tsmi_Tools.Name = "tsmi_Tools";
            this.tsmi_Tools.Size = new System.Drawing.Size(53, 21);
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
            this.tsmi_Help.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmi_Help.ForeColor = System.Drawing.Color.Black;
            this.tsmi_Help.Name = "tsmi_Help";
            this.tsmi_Help.Size = new System.Drawing.Size(49, 21);
            this.tsmi_Help.Text = "&Help";
            // 
            // tsmi_Help_About
            // 
            this.tsmi_Help_About.Name = "tsmi_Help_About";
            this.tsmi_Help_About.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Help_About.Text = "&About...";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Stop.BackgroundImage")));
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Stop.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Stop.Location = new System.Drawing.Point(454, 510);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(156, 26);
            this.btn_Stop.TabIndex = 8;
            this.btn_Stop.Text = "Stop / Cancel";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.OnStopButtonClick);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.64045F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.35955F));
            this.tableLayoutPanel1.Controls.Add(this.label_Age_TXT, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Gender_TXT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Culture, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Gender, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Age, 0, 3);
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
            // label_Age_TXT
            // 
            this.label_Age_TXT.AutoSize = true;
            this.label_Age_TXT.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Age_TXT.ForeColor = System.Drawing.Color.White;
            this.label_Age_TXT.Location = new System.Drawing.Point(126, 75);
            this.label_Age_TXT.Name = "label_Age_TXT";
            this.label_Age_TXT.Size = new System.Drawing.Size(27, 15);
            this.label_Age_TXT.TabIndex = 7;
            this.label_Age_TXT.Text = "-----";
            // 
            // label_Gender_TXT
            // 
            this.label_Gender_TXT.AutoSize = true;
            this.label_Gender_TXT.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender_TXT.ForeColor = System.Drawing.Color.White;
            this.label_Gender_TXT.Location = new System.Drawing.Point(126, 50);
            this.label_Gender_TXT.Name = "label_Gender_TXT";
            this.label_Gender_TXT.Size = new System.Drawing.Size(27, 15);
            this.label_Gender_TXT.TabIndex = 6;
            this.label_Gender_TXT.Text = "-----";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(3, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(43, 15);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name:";
            // 
            // label_Culture
            // 
            this.label_Culture.AutoSize = true;
            this.label_Culture.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Culture.ForeColor = System.Drawing.Color.White;
            this.label_Culture.Location = new System.Drawing.Point(3, 25);
            this.label_Culture.Name = "label_Culture";
            this.label_Culture.Size = new System.Drawing.Size(53, 15);
            this.label_Culture.TabIndex = 1;
            this.label_Culture.Text = "Culture:";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.ForeColor = System.Drawing.Color.White;
            this.label_Gender.Location = new System.Drawing.Point(3, 50);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(77, 15);
            this.label_Gender.TabIndex = 2;
            this.label_Gender.Text = "Description:";
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Age.ForeColor = System.Drawing.Color.White;
            this.label_Age.Location = new System.Drawing.Point(3, 75);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(31, 15);
            this.label_Age.TabIndex = 3;
            this.label_Age.Text = "Age:";
            // 
            // label_Name_TXT
            // 
            this.label_Name_TXT.AutoSize = true;
            this.label_Name_TXT.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name_TXT.ForeColor = System.Drawing.Color.White;
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
            this.label_Culture_TXT.ForeColor = System.Drawing.Color.White;
            this.label_Culture_TXT.Location = new System.Drawing.Point(126, 25);
            this.label_Culture_TXT.Name = "label_Culture_TXT";
            this.label_Culture_TXT.Size = new System.Drawing.Size(27, 15);
            this.label_Culture_TXT.TabIndex = 5;
            this.label_Culture_TXT.Text = "-----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Speech Options:";
            // 
            // contextMenuStrip_EditText
            // 
            this.contextMenuStrip_EditText.BackColor = System.Drawing.Color.DodgerBlue;
            this.contextMenuStrip_EditText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip_EditText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenu_Cut,
            this.contextMenu_Copy,
            this.contextMenu_Paste,
            this.toolStripSeparator5,
            this.contextMenu_SelectAll,
            this.toolStripSeparator6,
            this.contextMenu_Delete});
            this.contextMenuStrip_EditText.Name = "contextMenuStrip_EditText";
            this.contextMenuStrip_EditText.Size = new System.Drawing.Size(129, 126);
            this.contextMenuStrip_EditText.Text = "Edit Text";
            // 
            // contextMenu_Cut
            // 
            this.contextMenu_Cut.ForeColor = System.Drawing.Color.White;
            this.contextMenu_Cut.Image = ((System.Drawing.Image)(resources.GetObject("contextMenu_Cut.Image")));
            this.contextMenu_Cut.Name = "contextMenu_Cut";
            this.contextMenu_Cut.Size = new System.Drawing.Size(128, 22);
            this.contextMenu_Cut.Text = "Cut";
            this.contextMenu_Cut.Click += new System.EventHandler(this.OnEdit_CutClick);
            // 
            // contextMenu_Copy
            // 
            this.contextMenu_Copy.ForeColor = System.Drawing.Color.White;
            this.contextMenu_Copy.Image = ((System.Drawing.Image)(resources.GetObject("contextMenu_Copy.Image")));
            this.contextMenu_Copy.Name = "contextMenu_Copy";
            this.contextMenu_Copy.Size = new System.Drawing.Size(128, 22);
            this.contextMenu_Copy.Text = "Copy";
            this.contextMenu_Copy.Click += new System.EventHandler(this.OnEdit_CopyClick);
            // 
            // contextMenu_Paste
            // 
            this.contextMenu_Paste.ForeColor = System.Drawing.Color.White;
            this.contextMenu_Paste.Image = global::TextNarrator.ACResources.contextmenu_Paste_Icon;
            this.contextMenu_Paste.Name = "contextMenu_Paste";
            this.contextMenu_Paste.Size = new System.Drawing.Size(128, 22);
            this.contextMenu_Paste.Text = "Paste";
            this.contextMenu_Paste.Click += new System.EventHandler(this.OnEdit_PasteClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(125, 6);
            // 
            // contextMenu_SelectAll
            // 
            this.contextMenu_SelectAll.ForeColor = System.Drawing.Color.White;
            this.contextMenu_SelectAll.Image = ((System.Drawing.Image)(resources.GetObject("contextMenu_SelectAll.Image")));
            this.contextMenu_SelectAll.Name = "contextMenu_SelectAll";
            this.contextMenu_SelectAll.Size = new System.Drawing.Size(128, 22);
            this.contextMenu_SelectAll.Text = "Select All";
            this.contextMenu_SelectAll.Click += new System.EventHandler(this.OnEdit_SelectAllClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(125, 6);
            // 
            // contextMenu_Delete
            // 
            this.contextMenu_Delete.ForeColor = System.Drawing.Color.White;
            this.contextMenu_Delete.Image = ((System.Drawing.Image)(resources.GetObject("contextMenu_Delete.Image")));
            this.contextMenu_Delete.Name = "contextMenu_Delete";
            this.contextMenu_Delete.Size = new System.Drawing.Size(128, 22);
            this.contextMenu_Delete.Text = "Delete";
            this.contextMenu_Delete.Click += new System.EventHandler(this.OnEdit_DeleteClick);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(177, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(177, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
            this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem1.Text = "&New";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
            this.openToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem1.Text = "&Open";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "&Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem1.Text = "Save &As";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(177, 6);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem1.Image")));
            this.printToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem1.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem1
            // 
            this.printPreviewToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem1.Image")));
            this.printPreviewToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem1.Name = "printPreviewToolStripMenuItem1";
            this.printPreviewToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.printPreviewToolStripMenuItem1.Text = "Print Pre&view";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem1.Text = "&Undo";
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem1.Text = "&Redo";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(177, 6);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem1.Image")));
            this.cutToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem1.Text = "Cu&t";
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem1.Image")));
            this.copyToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem1.Text = "&Copy";
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem1.Image")));
            this.pasteToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem1.Text = "&Paste";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(177, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem1.Text = "Select &All";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem1.Text = "&Tools";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem1.Text = "&Options";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "&About...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_VoiceInfo);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Speak);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_TextToRead);
            this.Controls.Add(this.label_SelectVoice);
            this.Controls.Add(this.comboBox_Voices);
            this.Controls.Add(this.richTextBox_TextToRead);
            this.Controls.Add(this.menuStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Text Narrator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).EndInit();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.panel_VoiceInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip_EditText.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.TrackBar trackBar_Speed;
        private System.Windows.Forms.Label label_Volume;
        private System.Windows.Forms.Panel panel_VoiceInfo;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Culture;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_Age_TXT;
        private System.Windows.Forms.Label label_Gender_TXT;
        private System.Windows.Forms.Label label_Name_TXT;
        private System.Windows.Forms.Label label_Culture_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Speed_Value;
        private System.Windows.Forms.Label label_Volume_Value;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_EditText;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Cut;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Copy;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_SelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem contextMenu_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

