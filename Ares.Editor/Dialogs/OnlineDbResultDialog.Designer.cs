﻿namespace Ares.Editor.Dialogs
{
    partial class OnlineDbResultDialog
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineDbResultDialog));
            this.resultLabel = new System.Windows.Forms.Label();
            this.showLogButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removeDialogBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.secondLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.musicIdsLabel = new System.Windows.Forms.Label();
            this.addIdsLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            resources.ApplyResources(this.resultLabel, "resultLabel");
            this.resultLabel.Name = "resultLabel";
            // 
            // showLogButton
            // 
            resources.ApplyResources(this.showLogButton, "showLogButton");
            this.showLogButton.Name = "showLogButton";
            this.showLogButton.UseVisualStyleBackColor = true;
            this.showLogButton.Click += new System.EventHandler(this.showLogButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ares.Editor.ImageResources.Information;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.TabStop = false;
            // 
            // removeDialogBox
            // 
            resources.ApplyResources(this.removeDialogBox, "removeDialogBox");
            this.removeDialogBox.Name = "removeDialogBox";
            this.removeDialogBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // secondLabel
            // 
            resources.ApplyResources(this.secondLabel, "secondLabel");
            this.secondLabel.Name = "secondLabel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.secondLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.removeDialogBox, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.resultLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.showLogButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.musicIdsLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.addIdsLabel, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // musicIdsLabel
            // 
            resources.ApplyResources(this.musicIdsLabel, "musicIdsLabel");
            this.musicIdsLabel.Name = "musicIdsLabel";
            // 
            // addIdsLabel
            // 
            resources.ApplyResources(this.addIdsLabel, "addIdsLabel");
            this.addIdsLabel.Name = "addIdsLabel";
            this.addIdsLabel.TabStop = true;
            this.addIdsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addIdsLabel_LinkClicked);
            // 
            // OnlineDbResultDialog
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okButton;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnlineDbResultDialog";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button showLogButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox removeDialogBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label musicIdsLabel;
        private System.Windows.Forms.LinkLabel addIdsLabel;
    }
}