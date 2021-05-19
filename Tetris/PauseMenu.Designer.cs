
namespace Tetris
{
    partial class PauseMenu
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
            this.btContinue = new ButtonN();
            this.btToMenu = new ButtonN();
            this.btExit = new ButtonN();
            this.SuspendLayout();
            // 
            // btContinue
            // 

            this.btContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btContinue.BackColorAdditional = System.Drawing.Color.Magenta;
            this.btContinue.BackColorGradientEnabled = true;
            this.btContinue.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btContinue.BorderColor = System.Drawing.Color.Transparent;
            this.btContinue.BorderColorEnabled = false;
            this.btContinue.BorderColorOnHover = System.Drawing.Color.Transparent;
            this.btContinue.BorderColorOnHoverEnabled = false;
            this.btContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btContinue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btContinue.ForeColor = System.Drawing.Color.White;
            this.btContinue.Location = new System.Drawing.Point(18, 33);
            this.btContinue.Name = "btContinue";
            this.btContinue.RippleColor = System.Drawing.Color.Transparent;
            this.btContinue.RoundingEnable = true;
            this.btContinue.Size = new System.Drawing.Size(130, 30);
            this.btContinue.TabIndex = 0;
            this.btContinue.Text = "Продовжити";
            this.btContinue.TextHover = null;
            this.btContinue.UseDownPressEffectOnClick = true;
            this.btContinue.UseRippleEffect = true;
            this.btContinue.UseVisualStyleBackColor = false;
            this.btContinue.UseZoomEffectOnHover = false;
            // 
            // btToMenu
            // 
            
            this.btToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));

            this.btToMenu.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(00)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btToMenu.BackColorGradientEnabled = true;
            this.btToMenu.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btToMenu.BorderColor = System.Drawing.Color.Transparent;
            this.btToMenu.BorderColorEnabled = false;
            this.btToMenu.BorderColorOnHover = System.Drawing.Color.Transparent;
            this.btToMenu.BorderColorOnHoverEnabled = false;
            this.btToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btToMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btToMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btToMenu.ForeColor = System.Drawing.Color.White;
            this.btToMenu.Location = new System.Drawing.Point(18, 69);
            this.btToMenu.Name = "btToMenu";
            this.btToMenu.RippleColor = System.Drawing.Color.Transparent;
            this.btToMenu.RoundingEnable = true;
            this.btToMenu.Size = new System.Drawing.Size(130, 33);
            this.btToMenu.TabIndex = 1;
            this.btToMenu.Text = "Головне меню";
            this.btToMenu.TextHover = null;
            this.btToMenu.UseDownPressEffectOnClick = true;
            this.btToMenu.UseRippleEffect = true;
            this.btToMenu.UseVisualStyleBackColor = false;
            this.btToMenu.UseZoomEffectOnHover = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Tomato;
            this.btExit.BackColorAdditional = System.Drawing.Color.CornflowerBlue;
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
            this.btExit.Location = new System.Drawing.Point(18, 108);
            this.btExit.Name = "btExit";
            this.btExit.RippleColor = System.Drawing.Color.Transparent;
            this.btExit.RoundingEnable = true;
            this.btExit.Size = new System.Drawing.Size(130, 34);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Вихід";
            this.btExit.TextHover = null;
            this.btExit.UseDownPressEffectOnClick = true;
            this.btExit.UseRippleEffect = true;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.UseZoomEffectOnHover = false;
            // 
            // PauseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(175, 200);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btToMenu);
            this.Controls.Add(this.btContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PauseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StopMenu";
            this.TransparencyKey = this.BackColor;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private ButtonN btContinue;
        private ButtonN btToMenu;
        private ButtonN btExit;
    }
}