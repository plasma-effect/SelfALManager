namespace Manager
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.KANSENDataGrid = new System.Windows.Forms.DataGridView();
            this.addKANSEN = new System.Windows.Forms.Button();
            this.KANSENName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimitBreak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Awaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Love = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetLimit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KANSENDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // KANSENDataGrid
            // 
            this.KANSENDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KANSENDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KANSENName,
            this.LimitBreak,
            this.Awaken,
            this.Remodel,
            this.Love});
            this.KANSENDataGrid.Location = new System.Drawing.Point(12, 12);
            this.KANSENDataGrid.Name = "KANSENDataGrid";
            this.KANSENDataGrid.ReadOnly = true;
            this.KANSENDataGrid.RowHeadersWidth = 82;
            this.KANSENDataGrid.RowTemplate.Height = 33;
            this.KANSENDataGrid.Size = new System.Drawing.Size(844, 705);
            this.KANSENDataGrid.TabIndex = 0;
            // 
            // addKANSEN
            // 
            this.addKANSEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addKANSEN.Location = new System.Drawing.Point(862, 12);
            this.addKANSEN.Name = "addKANSEN";
            this.addKANSEN.Size = new System.Drawing.Size(200, 45);
            this.addKANSEN.TabIndex = 1;
            this.addKANSEN.Text = "KAN-SEN追加";
            this.addKANSEN.UseVisualStyleBackColor = true;
            this.addKANSEN.Click += new System.EventHandler(this.AddKANSENClick);
            // 
            // KANSENName
            // 
            this.KANSENName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KANSENName.Frozen = true;
            this.KANSENName.HeaderText = "名前";
            this.KANSENName.MinimumWidth = 10;
            this.KANSENName.Name = "KANSENName";
            this.KANSENName.ReadOnly = true;
            this.KANSENName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.KANSENName.Width = 64;
            // 
            // LimitBreak
            // 
            this.LimitBreak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LimitBreak.Frozen = true;
            this.LimitBreak.HeaderText = "限界突破";
            this.LimitBreak.MinimumWidth = 10;
            this.LimitBreak.Name = "LimitBreak";
            this.LimitBreak.ReadOnly = true;
            this.LimitBreak.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LimitBreak.Width = 112;
            // 
            // Awaken
            // 
            this.Awaken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Awaken.Frozen = true;
            this.Awaken.HeaderText = "認識覚醒";
            this.Awaken.MinimumWidth = 10;
            this.Awaken.Name = "Awaken";
            this.Awaken.ReadOnly = true;
            this.Awaken.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Awaken.Width = 112;
            // 
            // Remodel
            // 
            this.Remodel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Remodel.Frozen = true;
            this.Remodel.HeaderText = "改造";
            this.Remodel.MinimumWidth = 10;
            this.Remodel.Name = "Remodel";
            this.Remodel.ReadOnly = true;
            this.Remodel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Remodel.Width = 64;
            // 
            // Love
            // 
            this.Love.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Love.Frozen = true;
            this.Love.HeaderText = "愛";
            this.Love.MinimumWidth = 10;
            this.Love.Name = "Love";
            this.Love.ReadOnly = true;
            this.Love.Width = 79;
            // 
            // SetLimit
            // 
            this.SetLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetLimit.Location = new System.Drawing.Point(862, 63);
            this.SetLimit.Name = "SetLimit";
            this.SetLimit.Size = new System.Drawing.Size(200, 45);
            this.SetLimit.TabIndex = 2;
            this.SetLimit.Text = "限界突破セット";
            this.SetLimit.UseVisualStyleBackColor = true;
            this.SetLimit.Click += new System.EventHandler(this.SetLimitClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 729);
            this.Controls.Add(this.SetLimit);
            this.Controls.Add(this.addKANSEN);
            this.Controls.Add(this.KANSENDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.KANSENDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KANSENDataGrid;
        private System.Windows.Forms.Button addKANSEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KANSENName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimitBreak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Awaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Love;
        private System.Windows.Forms.Button SetLimit;
    }
}

