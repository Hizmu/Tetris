
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
            this.btCloseScore = new System.Windows.Forms.Button();
            this.scoreTetrisDataSet = new ScoreTetrisDataSet();
            this.scoreTetrisViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreTetrisViewTableAdapter = new ScoreTetrisDataSetTableAdapters.ScoreTetrisViewTableAdapter();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTetrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTetrisViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(57, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(50, 13);
            this.lbScore.TabIndex = 0;
            this.lbScore.Text = "Score : 0";
            // 
            // lbNext
            // 
            this.lbNext.AutoSize = true;
            this.lbNext.Location = new System.Drawing.Point(12, 55);
            this.lbNext.Name = "lbNext";
            this.lbNext.Size = new System.Drawing.Size(29, 13);
            this.lbNext.TabIndex = 1;
            this.lbNext.Text = "Next";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
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
            this.dgvScore.Location = new System.Drawing.Point(74, 9);
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.RowHeadersVisible = false;
            this.dgvScore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvScore.Size = new System.Drawing.Size(205, 354);
            this.dgvScore.TabIndex = 3;
            this.dgvScore.Visible = false;
            // 
            // btCloseScore
            // 
            this.btCloseScore.Location = new System.Drawing.Point(240, 369);
            this.btCloseScore.Name = "btCloseScore";
            this.btCloseScore.Size = new System.Drawing.Size(75, 23);
            this.btCloseScore.TabIndex = 4;
            this.btCloseScore.Text = "Закрити";
            this.btCloseScore.UseVisualStyleBackColor = true;
            this.btCloseScore.Visible = false;
            this.btCloseScore.Click += new System.EventHandler(this.btCloseScore_Click);
            // 
            // scoreTetrisDataSet
            // 
            this.scoreTetrisDataSet.DataSetName = "ScoreTetrisDataSet";
            this.scoreTetrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreTetrisViewBindingSource
            // 
            this.scoreTetrisViewBindingSource.DataMember = "ScoreTetrisView";
            this.scoreTetrisViewBindingSource.DataSource = this.scoreTetrisDataSet;
            // 
            // scoreTetrisViewTableAdapter
            // 
            this.scoreTetrisViewTableAdapter.ClearBeforeFill = true;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(336, 405);
            this.Controls.Add(this.btCloseScore);
            this.Controls.Add(this.dgvScore);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbNext);
            this.Controls.Add(this.lbScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Tetris";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Tetris_Load);
            this.Shown += new System.EventHandler(this.Tetris_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTetrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTetrisViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label lbScore;
        public System.Windows.Forms.Label lbNext;
        public System.Windows.Forms.Label lbLevel;
        public System.Windows.Forms.DataGridView dgvScore;
        public System.Windows.Forms.Button btCloseScore;
        private ScoreTetrisDataSet scoreTetrisDataSet;
        private System.Windows.Forms.BindingSource scoreTetrisViewBindingSource;
        private ScoreTetrisDataSetTableAdapters.ScoreTetrisViewTableAdapter scoreTetrisViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
    }
}

