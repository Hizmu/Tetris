
using System.Drawing;

namespace Tetris
{
    partial class MainMenu
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
            this.btStart = new System.Windows.Forms.Button();
            this.btTableScore = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btStart.Location = new System.Drawing.Point(68, 38);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(114, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btTableScore
            // 
            this.btTableScore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btTableScore.Location = new System.Drawing.Point(128, 67);
            this.btTableScore.Name = "btTableScore";
            this.btTableScore.Size = new System.Drawing.Size(114, 23);
            this.btTableScore.TabIndex = 1;
            this.btTableScore.Text = "Таблиця рекордів";
            this.btTableScore.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btExit.Location = new System.Drawing.Point(2, 67);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(114, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(68, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(114, 13);
            this.tbName.TabIndex = 3;
            this.tbName.Text = "Введіть ім\'я гравця";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 102);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btTableScore);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainWindow";
            this.TransparencyKey = this.BackColor;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btTableScore;
        private System.Windows.Forms.Button btExit;
        public System.Windows.Forms.TextBox tbName;
    }
}