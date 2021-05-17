
namespace Tetris
{
    partial class Tetris
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.lbNext = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(329, 41);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(50, 13);
            this.lbScore.TabIndex = 0;
            this.lbScore.Text = "Score : 0";
            // 
            // lbNext
            // 
            this.lbNext.AutoSize = true;
            this.lbNext.Location = new System.Drawing.Point(329, 127);
            this.lbNext.Name = "lbNext";
            this.lbNext.Size = new System.Drawing.Size(29, 13);
            this.lbNext.TabIndex = 1;
            this.lbNext.Text = "Next";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(332, 83);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(48, 13);
            this.lbLevel.TabIndex = 2;
            this.lbLevel.Text = "Level : 0";
            // 
            // pbNext
            // 
            this.pbNext.Location = new System.Drawing.Point(332, 172);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(100, 92);
            this.pbNext.TabIndex = 3;
            this.pbNext.TabStop = false;
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbNext);
            this.Controls.Add(this.lbScore);
            this.Name = "Tetris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tetris_Load);
            this.Shown += new System.EventHandler(this.Tetris_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbNext;
        public System.Windows.Forms.Label lbLevel;
        public System.Windows.Forms.PictureBox pbNext;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

