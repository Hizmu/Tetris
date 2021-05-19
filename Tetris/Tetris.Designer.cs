
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
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreTetrisViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTetrisDataSet = new ScoreTetrisDataSet();
            this.scoreTetrisViewTableAdapter = new ScoreTetrisDataSetTableAdapters.ScoreTetrisViewTableAdapter();
            this.btCloseScore = new ButtonN();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTetrisViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTetrisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(57, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(50, 13);
            this.lbScore.TabIndex = 0;
            this.lbScore.Text = "Score : 0";
            // 
            // lbNext
            // 
            this.lbNext.AutoSize = true;
            this.lbNext.BackColor = System.Drawing.Color.Transparent;
            this.lbNext.ForeColor = System.Drawing.Color.White;
            this.lbNext.Location = new System.Drawing.Point(12, 55);
            this.lbNext.Name = "lbNext";
            this.lbNext.Size = new System.Drawing.Size(29, 13);
            this.lbNext.TabIndex = 1;
            this.lbNext.Text = "Next";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.ForeColor = System.Drawing.Color.White;
            this.lbLevel.Location = new System.Drawing.Point(216, 9);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(48, 13);
            this.lbLevel.TabIndex = 2;
            this.lbLevel.Text = "Level : 0";
            // 
            // dgvScore
            // 
            this.dgvScore.AllowUserToAddRows = false;
            this.dgvScore.AllowUserToDeleteRows = false;
            this.dgvScore.AllowUserToResizeColumns = false;
            this.dgvScore.AllowUserToResizeRows = false;
            this.dgvScore.AutoGenerateColumns = false;
            this.dgvScore.BackgroundColor = this.BackColor;
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nicknameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dgvScore.DataSource = this.scoreTetrisViewBindingSource;
            this.dgvScore.Enabled = false;
            this.dgvScore.EnableHeadersVisualStyles = false;
            this.dgvScore.GridColor = System.Drawing.Color.Teal;
            this.dgvScore.Location = new System.Drawing.Point(60, 25);
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.ReadOnly = true;
            this.dgvScore.RowHeadersVisible = false;
            this.dgvScore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvScore.Size = new System.Drawing.Size(205, 354);
            this.dgvScore.TabIndex = 3;
            this.dgvScore.Visible = false;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            this.nicknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreTetrisViewBindingSource
            // 
            this.scoreTetrisViewBindingSource.DataMember = "ScoreTetrisView";
            this.scoreTetrisViewBindingSource.DataSource = this.scoreTetrisDataSet;
            // 
            // scoreTetrisDataSet
            // 
            this.scoreTetrisDataSet.DataSetName = "ScoreTetrisDataSet";
            this.scoreTetrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreTetrisViewTableAdapter
            // 
            this.scoreTetrisViewTableAdapter.ClearBeforeFill = true;
            // 
            // btCloseScore
            // 
            this.btCloseScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(88)))), ((int)(((byte)(208)))));
            this.btCloseScore.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(192)))));
            this.btCloseScore.BackColorGradientEnabled = true;
            this.btCloseScore.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btCloseScore.BorderColor = System.Drawing.Color.Tomato;
            this.btCloseScore.BorderColorEnabled = false;
            this.btCloseScore.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btCloseScore.BorderColorOnHoverEnabled = false;
            this.btCloseScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCloseScore.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btCloseScore.ForeColor = System.Drawing.Color.White;
            this.btCloseScore.Location = new System.Drawing.Point(240, 369);
            this.btCloseScore.Name = "btCloseScore";
            this.btCloseScore.RippleColor = System.Drawing.Color.Black;
            this.btCloseScore.RoundingEnable = false;
            this.btCloseScore.Size = new System.Drawing.Size(75, 23);
            this.btCloseScore.TabIndex = 4;
            this.btCloseScore.Text = "Закрити";
            this.btCloseScore.TextHover = null;
            this.btCloseScore.UseDownPressEffectOnClick = true;
            this.btCloseScore.UseRippleEffect = false;
            this.btCloseScore.UseVisualStyleBackColor = false;
            this.btCloseScore.UseZoomEffectOnHover = false;
            this.btCloseScore.Visible = false;
            this.btCloseScore.Click += new System.EventHandler(this.btCloseScore_Click);
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Resource._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(330, 400);
            this.Controls.Add(this.btCloseScore);
            this.Controls.Add(this.dgvScore);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbNext);
            this.Controls.Add(this.lbScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Tetris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Tetris_Load);
            this.Shown += new System.EventHandler(this.Tetris_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Tetris_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTetrisViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTetrisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label lbScore;
        public System.Windows.Forms.Label lbNext;
        public System.Windows.Forms.Label lbLevel;
        public System.Windows.Forms.DataGridView dgvScore;
        public ButtonN btCloseScore;
        private ScoreTetrisDataSet scoreTetrisDataSet;
        private System.Windows.Forms.BindingSource scoreTetrisViewBindingSource;
        private ScoreTetrisDataSetTableAdapters.ScoreTetrisViewTableAdapter scoreTetrisViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
    }
}

