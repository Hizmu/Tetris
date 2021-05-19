
using System.Drawing;
using System.Windows.Forms;

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
            this.tbName = new System.Windows.Forms.TextBox();
            this.btScore = new ButtonN();
            this.btExit = new ButtonN();
            this.btStart = new ButtonN();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BackColor = this.BackColor;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.SystemColors.Window;
            this.tbName.Location = new System.Drawing.Point(68, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(114, 29);
            this.tbName.TabIndex = 3;
            this.tbName.Text = "Player";
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // btScore
            // 
            this.btScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(233)))));
            this.btScore.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btScore.BackColorGradientEnabled = true;
            this.btScore.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btScore.BorderColor = System.Drawing.Color.Black;
            this.btScore.BorderColorEnabled = true;
            this.btScore.BorderColorOnHover = System.Drawing.Color.Transparent;
            this.btScore.BorderColorOnHoverEnabled = false;
            this.btScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btScore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btScore.ForeColor = System.Drawing.Color.White;
            this.btScore.Location = new System.Drawing.Point(68, 84);
            this.btScore.Name = "btScore";
            this.btScore.RippleColor = System.Drawing.Color.Transparent;
            this.btScore.RoundingEnable = true;
            this.btScore.Size = new System.Drawing.Size(114, 30);
            this.btScore.TabIndex = 6;
            this.btScore.Text = "Score";
            this.btScore.TextHover = null;
            this.btScore.UseDownPressEffectOnClick = true;
            this.btScore.UseRippleEffect = true;
            this.btScore.UseVisualStyleBackColor = false;
            this.btScore.UseZoomEffectOnHover = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(172)))));
            this.btExit.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(153)))));
            this.btExit.BackColorGradientEnabled = true;
            this.btExit.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btExit.BorderColor = System.Drawing.Color.Black;
            this.btExit.BorderColorEnabled = true;
            this.btExit.BorderColorOnHover = System.Drawing.Color.Transparent;
            this.btExit.BorderColorOnHoverEnabled = false;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(68, 127);
            this.btExit.Name = "btExit";
            this.btExit.RippleColor = System.Drawing.Color.Red;
            this.btExit.RoundingEnable = true;
            this.btExit.Size = new System.Drawing.Size(114, 30);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.TextHover = null;
            this.btExit.UseDownPressEffectOnClick = true;
            this.btExit.UseRippleEffect = true;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.UseZoomEffectOnHover = false;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Red;
            this.btStart.BackColorAdditional = System.Drawing.Color.Yellow;
            this.btStart.BackColorGradientEnabled = true;
            this.btStart.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btStart.BorderColor = System.Drawing.Color.Tomato;
            this.btStart.BorderColorEnabled = false;
            this.btStart.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btStart.BorderColorOnHoverEnabled = false;
            this.btStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.ForeColor = System.Drawing.Color.White;
            this.btStart.Location = new System.Drawing.Point(68, 47);
            this.btStart.Name = "btStart";
            this.btStart.RippleColor = System.Drawing.Color.Black;
            this.btStart.RoundingEnable = true;
            this.btStart.Size = new System.Drawing.Size(114, 31);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.TextHover = null;
            this.btStart.UseDownPressEffectOnClick = true;
            this.btStart.UseRippleEffect = true;
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.UseZoomEffectOnHover = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 169);
            this.Controls.Add(this.btScore);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbName);
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
        public System.Windows.Forms.TextBox tbName;
        private ButtonN btStart;
        private ButtonN btExit;
        private ButtonN btScore;
    }
}