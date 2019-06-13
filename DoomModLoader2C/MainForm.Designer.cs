﻿namespace DoomModLoader2
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.PathBinding = new System.Windows.Forms.BindingSource(this.components);
            this.cmdSavePreset = new System.Windows.Forms.Button();
            this.cmdRemovePreset = new System.Windows.Forms.Button();
            this.cmdRemovePWAD = new System.Windows.Forms.Button();
            this.cmdAddPWAD = new System.Windows.Forms.Button();
            this.lstPWAD = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.chkCustomConfiguration = new System.Windows.Forms.CheckBox();
            this.cmdAddConfiguration = new System.Windows.Forms.Button();
            this.cmdRemoveConfiguration = new System.Windows.Forms.Button();
            this.cmbPortConfig = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdAddSourcePort = new System.Windows.Forms.Button();
            this.cmdAddIWAD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdRemoveSourcePort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdRemoveIWAD = new System.Windows.Forms.Button();
            this.cmbIWAD = new System.Windows.Forms.ComboBox();
            this.cmbSourcePort = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbSkill = new System.Windows.Forms.ComboBox();
            this.txtMap = new System.Windows.Forms.TextBox();
            this.chkNoMonster = new System.Windows.Forms.CheckBox();
            this.chkRespawn = new System.Windows.Forms.CheckBox();
            this.chkFast = new System.Windows.Forms.CheckBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_vidrender = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtScreenHeight = new System.Windows.Forms.TextBox();
            this.chkFullscreen = new System.Windows.Forms.CheckBox();
            this.txtScreenWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radAudioNoMusic = new System.Windows.Forms.RadioButton();
            this.radAudioNoSFX = new System.Windows.Forms.RadioButton();
            this.radAudioNoSounds = new System.Windows.Forms.RadioButton();
            this.radAudioAllSounds = new System.Windows.Forms.RadioButton();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PathBinding)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPreset);
            this.groupBox1.Controls.Add(this.cmdSavePreset);
            this.groupBox1.Controls.Add(this.cmdRemovePreset);
            this.groupBox1.Controls.Add(this.cmdRemovePWAD);
            this.groupBox1.Controls.Add(this.cmdAddPWAD);
            this.groupBox1.Controls.Add(this.lstPWAD);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MOD(-PWAD)";
            // 
            // cmbPreset
            // 
            this.cmbPreset.DataSource = this.PathBinding;
            this.cmbPreset.DisplayMember = "name";
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(6, 482);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(302, 21);
            this.cmbPreset.TabIndex = 18;
            this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
            // 
            // PathBinding
            // 
            this.PathBinding.DataSource = typeof(DoomModLoader2.Entity.PathName);
            // 
            // cmdSavePreset
            // 
            this.cmdSavePreset.Location = new System.Drawing.Point(6, 453);
            this.cmdSavePreset.Name = "cmdSavePreset";
            this.cmdSavePreset.Size = new System.Drawing.Size(220, 23);
            this.cmdSavePreset.TabIndex = 17;
            this.cmdSavePreset.Text = "SAVE PRESET";
            this.cmdSavePreset.UseVisualStyleBackColor = true;
            this.cmdSavePreset.Click += new System.EventHandler(this.cmdSavePreset_Click);
            // 
            // cmdRemovePreset
            // 
            this.cmdRemovePreset.Location = new System.Drawing.Point(232, 452);
            this.cmdRemovePreset.Name = "cmdRemovePreset";
            this.cmdRemovePreset.Size = new System.Drawing.Size(76, 24);
            this.cmdRemovePreset.TabIndex = 15;
            this.cmdRemovePreset.Text = "REMOVE...";
            this.cmdRemovePreset.UseVisualStyleBackColor = true;
            this.cmdRemovePreset.Click += new System.EventHandler(this.cmdRemovePreset_Click);
            // 
            // cmdRemovePWAD
            // 
            this.cmdRemovePWAD.Location = new System.Drawing.Point(170, 18);
            this.cmdRemovePWAD.Name = "cmdRemovePWAD";
            this.cmdRemovePWAD.Size = new System.Drawing.Size(138, 24);
            this.cmdRemovePWAD.TabIndex = 19;
            this.cmdRemovePWAD.Text = "REMOVE...";
            this.cmdRemovePWAD.UseVisualStyleBackColor = true;
            this.cmdRemovePWAD.Click += new System.EventHandler(this.cmdRemovePWAD_Click);
            // 
            // cmdAddPWAD
            // 
            this.cmdAddPWAD.Location = new System.Drawing.Point(6, 19);
            this.cmdAddPWAD.Name = "cmdAddPWAD";
            this.cmdAddPWAD.Size = new System.Drawing.Size(138, 23);
            this.cmdAddPWAD.TabIndex = 16;
            this.cmdAddPWAD.Text = "ADD...";
            this.cmdAddPWAD.UseVisualStyleBackColor = true;
            this.cmdAddPWAD.Click += new System.EventHandler(this.cmdAddPWAD_Click);
            // 
            // lstPWAD
            // 
            this.lstPWAD.DataSource = this.PathBinding;
            this.lstPWAD.DisplayMember = "name";
            this.lstPWAD.FormattingEnabled = true;
            this.lstPWAD.Location = new System.Drawing.Point(6, 45);
            this.lstPWAD.Name = "lstPWAD";
            this.lstPWAD.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPWAD.Size = new System.Drawing.Size(302, 394);
            this.lstPWAD.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 509);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Launch Options";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.chkCustomConfiguration);
            this.groupBox9.Controls.Add(this.cmdAddConfiguration);
            this.groupBox9.Controls.Add(this.cmdRemoveConfiguration);
            this.groupBox9.Controls.Add(this.cmbPortConfig);
            this.groupBox9.Location = new System.Drawing.Point(7, 358);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(549, 81);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Game";
            // 
            // chkCustomConfiguration
            // 
            this.chkCustomConfiguration.AutoSize = true;
            this.chkCustomConfiguration.Location = new System.Drawing.Point(6, 23);
            this.chkCustomConfiguration.Name = "chkCustomConfiguration";
            this.chkCustomConfiguration.Size = new System.Drawing.Size(253, 17);
            this.chkCustomConfiguration.TabIndex = 16;
            this.chkCustomConfiguration.Text = "Use alternative engine configuration file (-config)";
            this.chkCustomConfiguration.UseVisualStyleBackColor = true;
            this.chkCustomConfiguration.CheckedChanged += new System.EventHandler(this.chkCustomConfiguration_CheckedChanged);
            // 
            // cmdAddConfiguration
            // 
            this.cmdAddConfiguration.Location = new System.Drawing.Point(385, 19);
            this.cmdAddConfiguration.Name = "cmdAddConfiguration";
            this.cmdAddConfiguration.Size = new System.Drawing.Size(76, 23);
            this.cmdAddConfiguration.TabIndex = 13;
            this.cmdAddConfiguration.Text = "ADD...";
            this.cmdAddConfiguration.UseVisualStyleBackColor = true;
            this.cmdAddConfiguration.Click += new System.EventHandler(this.cmdAddConfiguration_Click);
            // 
            // cmdRemoveConfiguration
            // 
            this.cmdRemoveConfiguration.Location = new System.Drawing.Point(467, 18);
            this.cmdRemoveConfiguration.Name = "cmdRemoveConfiguration";
            this.cmdRemoveConfiguration.Size = new System.Drawing.Size(76, 24);
            this.cmdRemoveConfiguration.TabIndex = 8;
            this.cmdRemoveConfiguration.Text = "REMOVE...";
            this.cmdRemoveConfiguration.UseVisualStyleBackColor = true;
            this.cmdRemoveConfiguration.Click += new System.EventHandler(this.cmdRemoveConfiguration_Click);
            // 
            // cmbPortConfig
            // 
            this.cmbPortConfig.DataSource = this.PathBinding;
            this.cmbPortConfig.DisplayMember = "name";
            this.cmbPortConfig.FormattingEnabled = true;
            this.cmbPortConfig.Location = new System.Drawing.Point(6, 48);
            this.cmbPortConfig.Name = "cmbPortConfig";
            this.cmbPortConfig.Size = new System.Drawing.Size(537, 21);
            this.cmbPortConfig.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtCommandLine);
            this.groupBox8.Location = new System.Drawing.Point(6, 453);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(550, 50);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Custom command line parameters";
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Location = new System.Drawing.Point(6, 19);
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(538, 20);
            this.txtCommandLine.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdAddSourcePort);
            this.groupBox6.Controls.Add(this.cmdAddIWAD);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.cmdRemoveSourcePort);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.cmdRemoveIWAD);
            this.groupBox6.Controls.Add(this.cmbIWAD);
            this.groupBox6.Controls.Add(this.cmbSourcePort);
            this.groupBox6.Location = new System.Drawing.Point(7, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(549, 72);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Game";
            // 
            // cmdAddSourcePort
            // 
            this.cmdAddSourcePort.Location = new System.Drawing.Point(74, 15);
            this.cmdAddSourcePort.Name = "cmdAddSourcePort";
            this.cmdAddSourcePort.Size = new System.Drawing.Size(76, 24);
            this.cmdAddSourcePort.TabIndex = 14;
            this.cmdAddSourcePort.Text = "ADD...";
            this.cmdAddSourcePort.UseVisualStyleBackColor = true;
            this.cmdAddSourcePort.Click += new System.EventHandler(this.cmdAddSourcePort_Click);
            // 
            // cmdAddIWAD
            // 
            this.cmdAddIWAD.Location = new System.Drawing.Point(388, 15);
            this.cmdAddIWAD.Name = "cmdAddIWAD";
            this.cmdAddIWAD.Size = new System.Drawing.Size(76, 23);
            this.cmdAddIWAD.TabIndex = 13;
            this.cmdAddIWAD.Text = "ADD...";
            this.cmdAddIWAD.UseVisualStyleBackColor = true;
            this.cmdAddIWAD.Click += new System.EventHandler(this.cmdAddIWAD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Source Port:";
            // 
            // cmdRemoveSourcePort
            // 
            this.cmdRemoveSourcePort.Location = new System.Drawing.Point(156, 15);
            this.cmdRemoveSourcePort.Name = "cmdRemoveSourcePort";
            this.cmdRemoveSourcePort.Size = new System.Drawing.Size(76, 24);
            this.cmdRemoveSourcePort.TabIndex = 11;
            this.cmdRemoveSourcePort.Text = "REMOVE...";
            this.cmdRemoveSourcePort.UseVisualStyleBackColor = true;
            this.cmdRemoveSourcePort.Click += new System.EventHandler(this.cmdRemoveSourcePort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Original Game .wad (-IWAD):";
            // 
            // cmdRemoveIWAD
            // 
            this.cmdRemoveIWAD.Location = new System.Drawing.Point(470, 14);
            this.cmdRemoveIWAD.Name = "cmdRemoveIWAD";
            this.cmdRemoveIWAD.Size = new System.Drawing.Size(76, 24);
            this.cmdRemoveIWAD.TabIndex = 8;
            this.cmdRemoveIWAD.Text = "REMOVE...";
            this.cmdRemoveIWAD.UseVisualStyleBackColor = true;
            this.cmdRemoveIWAD.Click += new System.EventHandler(this.cmdRemoveIWAD_Click);
            // 
            // cmbIWAD
            // 
            this.cmbIWAD.DataSource = this.PathBinding;
            this.cmbIWAD.DisplayMember = "name";
            this.cmbIWAD.FormattingEnabled = true;
            this.cmbIWAD.Location = new System.Drawing.Point(238, 41);
            this.cmbIWAD.Name = "cmbIWAD";
            this.cmbIWAD.Size = new System.Drawing.Size(305, 21);
            this.cmbIWAD.TabIndex = 1;
            // 
            // cmbSourcePort
            // 
            this.cmbSourcePort.DataSource = this.PathBinding;
            this.cmbSourcePort.DisplayMember = "name";
            this.cmbSourcePort.FormattingEnabled = true;
            this.cmbSourcePort.Location = new System.Drawing.Point(6, 41);
            this.cmbSourcePort.Name = "cmbSourcePort";
            this.cmbSourcePort.Size = new System.Drawing.Size(226, 21);
            this.cmbSourcePort.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbSkill);
            this.groupBox5.Controls.Add(this.txtMap);
            this.groupBox5.Controls.Add(this.chkNoMonster);
            this.groupBox5.Controls.Add(this.chkRespawn);
            this.groupBox5.Controls.Add(this.chkFast);
            this.groupBox5.Controls.Add(this.lblSkill);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(236, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 129);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gameplay";
            // 
            // cmbSkill
            // 
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.Items.AddRange(new object[] {
            "I\'m too young to die",
            "Hey, not too rough",
            "Hurt me plenty",
            "Ultra-Violence",
            "Nightmare!"});
            this.cmbSkill.Location = new System.Drawing.Point(128, 42);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(186, 21);
            this.cmbSkill.TabIndex = 15;
            // 
            // txtMap
            // 
            this.txtMap.Location = new System.Drawing.Point(128, 18);
            this.txtMap.Name = "txtMap";
            this.txtMap.Size = new System.Drawing.Size(186, 20);
            this.txtMap.TabIndex = 8;
            this.txtMap.TextChanged += new System.EventHandler(this.txtMap_TextChanged);
            // 
            // chkNoMonster
            // 
            this.chkNoMonster.AutoSize = true;
            this.chkNoMonster.Location = new System.Drawing.Point(6, 66);
            this.chkNoMonster.Name = "chkNoMonster";
            this.chkNoMonster.Size = new System.Drawing.Size(173, 17);
            this.chkNoMonster.TabIndex = 4;
            this.chkNoMonster.Text = "Remove Monster (-nomonsters)";
            this.chkNoMonster.UseVisualStyleBackColor = true;
            this.chkNoMonster.CheckedChanged += new System.EventHandler(this.chkNoMonster_CheckedChanged);
            // 
            // chkRespawn
            // 
            this.chkRespawn.AutoSize = true;
            this.chkRespawn.Location = new System.Drawing.Point(6, 106);
            this.chkRespawn.Name = "chkRespawn";
            this.chkRespawn.Size = new System.Drawing.Size(164, 17);
            this.chkRespawn.TabIndex = 3;
            this.chkRespawn.Text = "Monster Respawn (-respawn)";
            this.chkRespawn.UseVisualStyleBackColor = true;
            // 
            // chkFast
            // 
            this.chkFast.AutoSize = true;
            this.chkFast.Location = new System.Drawing.Point(6, 86);
            this.chkFast.Name = "chkFast";
            this.chkFast.Size = new System.Drawing.Size(116, 17);
            this.chkFast.TabIndex = 2;
            this.chkFast.Text = "Fast Monster (-fast)";
            this.chkFast.UseVisualStyleBackColor = true;
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(3, 42);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(80, 13);
            this.lblSkill.TabIndex = 1;
            this.lblSkill.Text = "Skill level (-skill)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start from level (+map)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_vidrender);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(7, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(552, 123);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Video";
            // 
            // cmb_vidrender
            // 
            this.cmb_vidrender.FormattingEnabled = true;
            this.cmb_vidrender.Items.AddRange(new object[] {
            "DOOM SOFTWARE RENDERER",
            "TRUE COLOR SOFTWARE RENDERER",
            "SOFTPOLY RENDERER",
            "TRUE COLOR SOFTPOLY",
            "HARDWARE ACCELERATED"});
            this.cmb_vidrender.Location = new System.Drawing.Point(5, 97);
            this.cmb_vidrender.Name = "cmb_vidrender";
            this.cmb_vidrender.Size = new System.Drawing.Size(538, 21);
            this.cmb_vidrender.TabIndex = 15;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtScreenHeight);
            this.groupBox7.Controls.Add(this.chkFullscreen);
            this.groupBox7.Controls.Add(this.txtScreenWidth);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(6, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(537, 62);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resolution";
            // 
            // txtScreenHeight
            // 
            this.txtScreenHeight.Location = new System.Drawing.Point(223, 32);
            this.txtScreenHeight.Name = "txtScreenHeight";
            this.txtScreenHeight.Size = new System.Drawing.Size(199, 20);
            this.txtScreenHeight.TabIndex = 7;
            // 
            // chkFullscreen
            // 
            this.chkFullscreen.AutoSize = true;
            this.chkFullscreen.Checked = true;
            this.chkFullscreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFullscreen.Location = new System.Drawing.Point(440, 32);
            this.chkFullscreen.Name = "chkFullscreen";
            this.chkFullscreen.Size = new System.Drawing.Size(77, 17);
            this.chkFullscreen.TabIndex = 6;
            this.chkFullscreen.Text = "+fullscreen";
            this.chkFullscreen.UseVisualStyleBackColor = true;
            // 
            // txtScreenWidth
            // 
            this.txtScreenWidth.Location = new System.Drawing.Point(6, 33);
            this.txtScreenWidth.Name = "txtScreenWidth";
            this.txtScreenWidth.Size = new System.Drawing.Size(199, 20);
            this.txtScreenWidth.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "-height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "-width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "+vid_rendermode";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radAudioNoMusic);
            this.groupBox3.Controls.Add(this.radAudioNoSFX);
            this.groupBox3.Controls.Add(this.radAudioNoSounds);
            this.groupBox3.Controls.Add(this.radAudioAllSounds);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 129);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Audio";
            // 
            // radAudioNoMusic
            // 
            this.radAudioNoMusic.AutoSize = true;
            this.radAudioNoMusic.Location = new System.Drawing.Point(6, 88);
            this.radAudioNoMusic.Name = "radAudioNoMusic";
            this.radAudioNoMusic.Size = new System.Drawing.Size(142, 17);
            this.radAudioNoMusic.TabIndex = 3;
            this.radAudioNoMusic.Text = "Disable Music (-nomusic)";
            this.radAudioNoMusic.UseVisualStyleBackColor = true;
            // 
            // radAudioNoSFX
            // 
            this.radAudioNoSFX.AutoSize = true;
            this.radAudioNoSFX.Location = new System.Drawing.Point(6, 65);
            this.radAudioNoSFX.Name = "radAudioNoSFX";
            this.radAudioNoSFX.Size = new System.Drawing.Size(120, 17);
            this.radAudioNoSFX.TabIndex = 2;
            this.radAudioNoSFX.Text = "Disable SFX (-nosfx)";
            this.radAudioNoSFX.UseVisualStyleBackColor = true;
            // 
            // radAudioNoSounds
            // 
            this.radAudioNoSounds.AutoSize = true;
            this.radAudioNoSounds.Location = new System.Drawing.Point(6, 42);
            this.radAudioNoSounds.Name = "radAudioNoSounds";
            this.radAudioNoSounds.Size = new System.Drawing.Size(163, 17);
            this.radAudioNoSounds.TabIndex = 1;
            this.radAudioNoSounds.Text = "Disable all sounds (-nosound)";
            this.radAudioNoSounds.UseVisualStyleBackColor = true;
            // 
            // radAudioAllSounds
            // 
            this.radAudioAllSounds.AutoSize = true;
            this.radAudioAllSounds.Checked = true;
            this.radAudioAllSounds.Location = new System.Drawing.Point(6, 19);
            this.radAudioAllSounds.Name = "radAudioAllSounds";
            this.radAudioAllSounds.Size = new System.Drawing.Size(108, 17);
            this.radAudioAllSounds.TabIndex = 0;
            this.radAudioAllSounds.TabStop = true;
            this.radAudioAllSounds.Text = "Enable all sounds";
            this.radAudioAllSounds.UseVisualStyleBackColor = true;
            // 
            // cmdPlay
            // 
            this.cmdPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlay.Location = new System.Drawing.Point(10, 527);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(885, 82);
            this.cmdPlay.TabIndex = 2;
            this.cmdPlay.Text = "PLAY";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 621);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Doom Mod Loader 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PathBinding)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbIWAD;
        private System.Windows.Forms.ComboBox cmbSourcePort;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScreenWidth;
        private System.Windows.Forms.RadioButton radAudioNoMusic;
        private System.Windows.Forms.RadioButton radAudioNoSFX;
        private System.Windows.Forms.RadioButton radAudioNoSounds;
        private System.Windows.Forms.RadioButton radAudioAllSounds;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtScreenHeight;
        private System.Windows.Forms.CheckBox chkFullscreen;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.ListBox lstPWAD;
        private System.Windows.Forms.CheckBox chkNoMonster;
        private System.Windows.Forms.CheckBox chkRespawn;
        private System.Windows.Forms.CheckBox chkFast;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdRemoveIWAD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdRemoveSourcePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.Button cmdSavePreset;
        private System.Windows.Forms.Button cmdAddPWAD;
        private System.Windows.Forms.Button cmdRemovePreset;
        private System.Windows.Forms.Button cmdAddSourcePort;
        private System.Windows.Forms.Button cmdAddIWAD;
        private System.Windows.Forms.Button cmdRemovePWAD;
        private System.Windows.Forms.ComboBox cmbSkill;
        private System.Windows.Forms.TextBox txtMap;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button cmdAddConfiguration;
        private System.Windows.Forms.Button cmdRemoveConfiguration;
        private System.Windows.Forms.ComboBox cmbPortConfig;
        private System.Windows.Forms.BindingSource PathBinding;
        private System.Windows.Forms.CheckBox chkCustomConfiguration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_vidrender;
    }
}
