﻿namespace DoomModLoader2
{
    partial class FormMod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMod));
            this.cmdUp = new System.Windows.Forms.Button();
            this.cmdDown = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.lstPwad = new System.Windows.Forms.ListBox();
            this.PathNameSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdSavePreset = new System.Windows.Forms.Button();
            this.txtPresetName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PathNameSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdUp
            // 
            this.cmdUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUp.Location = new System.Drawing.Point(411, 24);
            this.cmdUp.Name = "cmdUp";
            this.cmdUp.Size = new System.Drawing.Size(158, 46);
            this.cmdUp.TabIndex = 0;
            this.cmdUp.Text = "UP";
            this.cmdUp.UseVisualStyleBackColor = true;
            this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
            // 
            // cmdDown
            // 
            this.cmdDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDown.Location = new System.Drawing.Point(411, 76);
            this.cmdDown.Name = "cmdDown";
            this.cmdDown.Size = new System.Drawing.Size(158, 46);
            this.cmdDown.TabIndex = 1;
            this.cmdDown.Text = "DOWN";
            this.cmdDown.UseVisualStyleBackColor = true;
            this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlay.Location = new System.Drawing.Point(12, 283);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(553, 61);
            this.cmdPlay.TabIndex = 2;
            this.cmdPlay.Text = "PLAY";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // lstPwad
            // 
            this.lstPwad.DataSource = this.PathNameSource;
            this.lstPwad.DisplayMember = "name";
            this.lstPwad.FormattingEnabled = true;
            this.lstPwad.Location = new System.Drawing.Point(12, 12);
            this.lstPwad.Name = "lstPwad";
            this.lstPwad.Size = new System.Drawing.Size(393, 225);
            this.lstPwad.TabIndex = 3;
            // 
            // PathNameSource
            // 
            this.PathNameSource.DataSource = typeof(DoomModLoader2.Entity.PathName);
            // 
            // cmdSavePreset
            // 
            this.cmdSavePreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSavePreset.Location = new System.Drawing.Point(12, 243);
            this.cmdSavePreset.Name = "cmdSavePreset";
            this.cmdSavePreset.Size = new System.Drawing.Size(167, 34);
            this.cmdSavePreset.TabIndex = 4;
            this.cmdSavePreset.Text = "SAVE PRESET";
            this.cmdSavePreset.UseVisualStyleBackColor = true;
            this.cmdSavePreset.Click += new System.EventHandler(this.cmdSavePreset_Click);
            // 
            // txtPresetName
            // 
            this.txtPresetName.Location = new System.Drawing.Point(185, 252);
            this.txtPresetName.Name = "txtPresetName";
            this.txtPresetName.Size = new System.Drawing.Size(380, 20);
            this.txtPresetName.TabIndex = 5;
            // 
            // FormMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 352);
            this.Controls.Add(this.txtPresetName);
            this.Controls.Add(this.cmdSavePreset);
            this.Controls.Add(this.lstPwad);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.cmdDown);
            this.Controls.Add(this.cmdUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMod";
            this.Text = "Mod Loading Order";
            this.Load += new System.EventHandler(this.FormMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PathNameSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUp;
        private System.Windows.Forms.Button cmdDown;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.ListBox lstPwad;
        private System.Windows.Forms.BindingSource PathNameSource;
        private System.Windows.Forms.Button cmdSavePreset;
        private System.Windows.Forms.TextBox txtPresetName;
    }
}