
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
            
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).BeginInit();
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
            this.btn_Clear.Text = global::TextNarrator.ACResources.Clear_Button_TXT;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.OnClearButtonClick);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

