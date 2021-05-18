
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
            this.btContinue = new System.Windows.Forms.Button();
            this.btToMenu = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btContinue
            // 
            this.btContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btContinue.Location = new System.Drawing.Point(41, 40);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(90, 23);
            this.btContinue.TabIndex = 0;
            this.btContinue.Text = "Продовжити";
            this.btContinue.UseVisualStyleBackColor = true;
            // 
            // btToMenu
            // 
            this.btToMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btToMenu.Location = new System.Drawing.Point(41, 79);
            this.btToMenu.Name = "btToMenu";
            this.btToMenu.Size = new System.Drawing.Size(90, 23);
            this.btToMenu.TabIndex = 1;
            this.btToMenu.Text = "Головне меню";
            this.btToMenu.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btExit.Location = new System.Drawing.Point(41, 119);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(90, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // StopMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 200);
            this.ControlBox = false;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btToMenu);
            this.Controls.Add(this.btContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "StopMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StopMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.Button btToMenu;
        private System.Windows.Forms.Button btExit;
    }
}