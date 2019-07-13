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
            this.KANSENName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimitBreak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Awaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Love = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Story = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addKANSEN = new System.Windows.Forms.Button();
            this.SetLimit = new System.Windows.Forms.Button();
            this.AwakenSet = new System.Windows.Forms.Button();
            this.ImplementRemodel = new System.Windows.Forms.Button();
            this.Remodeled = new System.Windows.Forms.Button();
            this.LoveSet = new System.Windows.Forms.Button();
            this.AddStory = new System.Windows.Forms.Button();
            this.CompleteStory = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.limitBreakCountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.awakenCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.remodeledCountLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.loveCountLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.storyCompleteCountLabel = new System.Windows.Forms.Label();
            this.getKANSEN = new System.Windows.Forms.Button();
            this.nameFilter = new System.Windows.Forms.Button();
            this.filterReset = new System.Windows.Forms.Button();
            this.notThreeFilter = new System.Windows.Forms.Button();
            this.notAwakenFilter = new System.Windows.Forms.Button();
            this.notRemodeledFilter = new System.Windows.Forms.Button();
            this.notLoveFilter = new System.Windows.Forms.Button();
            this.notStoryCompleteFilter = new System.Windows.Forms.Button();
            this.notGetsFilter = new System.Windows.Forms.Button();
            this.sortByBreakInc = new System.Windows.Forms.Button();
            this.sortByBreakDec = new System.Windows.Forms.Button();
            this.getsFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KANSENDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // KANSENDataGrid
            // 
            this.KANSENDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KANSENDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KANSENDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KANSENName,
            this.Gets,
            this.LimitBreak,
            this.Awaken,
            this.Remodel,
            this.Love,
            this.Story});
            this.KANSENDataGrid.Location = new System.Drawing.Point(12, 12);
            this.KANSENDataGrid.Name = "KANSENDataGrid";
            this.KANSENDataGrid.ReadOnly = true;
            this.KANSENDataGrid.RowHeadersWidth = 82;
            this.KANSENDataGrid.RowTemplate.Height = 33;
            this.KANSENDataGrid.Size = new System.Drawing.Size(1138, 905);
            this.KANSENDataGrid.TabIndex = 0;
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
            // Gets
            // 
            this.Gets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Gets.Frozen = true;
            this.Gets.HeaderText = "取得済み";
            this.Gets.MinimumWidth = 10;
            this.Gets.Name = "Gets";
            this.Gets.ReadOnly = true;
            this.Gets.Width = 148;
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
            // Story
            // 
            this.Story.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Story.Frozen = true;
            this.Story.HeaderText = "ストーリー";
            this.Story.MinimumWidth = 10;
            this.Story.Name = "Story";
            this.Story.ReadOnly = true;
            this.Story.Width = 144;
            // 
            // addKANSEN
            // 
            this.addKANSEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addKANSEN.Location = new System.Drawing.Point(1156, 12);
            this.addKANSEN.Name = "addKANSEN";
            this.addKANSEN.Size = new System.Drawing.Size(200, 45);
            this.addKANSEN.TabIndex = 1;
            this.addKANSEN.Text = "KAN-SEN追加";
            this.addKANSEN.UseVisualStyleBackColor = true;
            this.addKANSEN.Click += new System.EventHandler(this.AddKANSENClick);
            // 
            // SetLimit
            // 
            this.SetLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetLimit.Location = new System.Drawing.Point(1156, 114);
            this.SetLimit.Name = "SetLimit";
            this.SetLimit.Size = new System.Drawing.Size(200, 45);
            this.SetLimit.TabIndex = 2;
            this.SetLimit.Text = "限界突破セット";
            this.SetLimit.UseVisualStyleBackColor = true;
            this.SetLimit.Click += new System.EventHandler(this.SetLimitClick);
            // 
            // AwakenSet
            // 
            this.AwakenSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AwakenSet.Location = new System.Drawing.Point(1156, 165);
            this.AwakenSet.Name = "AwakenSet";
            this.AwakenSet.Size = new System.Drawing.Size(200, 45);
            this.AwakenSet.TabIndex = 3;
            this.AwakenSet.Text = "認識覚醒セット";
            this.AwakenSet.UseVisualStyleBackColor = true;
            this.AwakenSet.Click += new System.EventHandler(this.AwakenSetClick);
            // 
            // ImplementRemodel
            // 
            this.ImplementRemodel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImplementRemodel.Location = new System.Drawing.Point(1156, 267);
            this.ImplementRemodel.Name = "ImplementRemodel";
            this.ImplementRemodel.Size = new System.Drawing.Size(200, 45);
            this.ImplementRemodel.TabIndex = 5;
            this.ImplementRemodel.Text = "改造実装追加";
            this.ImplementRemodel.UseVisualStyleBackColor = true;
            this.ImplementRemodel.Click += new System.EventHandler(this.ImplementRemodelClick);
            // 
            // Remodeled
            // 
            this.Remodeled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Remodeled.Location = new System.Drawing.Point(1156, 318);
            this.Remodeled.Name = "Remodeled";
            this.Remodeled.Size = new System.Drawing.Size(200, 45);
            this.Remodeled.TabIndex = 6;
            this.Remodeled.Text = "改造完了";
            this.Remodeled.UseVisualStyleBackColor = true;
            this.Remodeled.Click += new System.EventHandler(this.RemodeledClick);
            // 
            // LoveSet
            // 
            this.LoveSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoveSet.Location = new System.Drawing.Point(1156, 420);
            this.LoveSet.Name = "LoveSet";
            this.LoveSet.Size = new System.Drawing.Size(200, 45);
            this.LoveSet.TabIndex = 8;
            this.LoveSet.Text = "愛セット";
            this.LoveSet.UseVisualStyleBackColor = true;
            this.LoveSet.Click += new System.EventHandler(this.LoveSetClick);
            // 
            // AddStory
            // 
            this.AddStory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddStory.Location = new System.Drawing.Point(1156, 471);
            this.AddStory.Name = "AddStory";
            this.AddStory.Size = new System.Drawing.Size(200, 45);
            this.AddStory.TabIndex = 10;
            this.AddStory.Text = "ストーリー実装";
            this.AddStory.UseVisualStyleBackColor = true;
            this.AddStory.Click += new System.EventHandler(this.AddStoryClick);
            // 
            // CompleteStory
            // 
            this.CompleteStory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteStory.Location = new System.Drawing.Point(1156, 522);
            this.CompleteStory.Name = "CompleteStory";
            this.CompleteStory.Size = new System.Drawing.Size(200, 45);
            this.CompleteStory.TabIndex = 11;
            this.CompleteStory.Text = "ストーリー完了";
            this.CompleteStory.UseVisualStyleBackColor = true;
            this.CompleteStory.Click += new System.EventHandler(this.CompleteStoryClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(1362, 872);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(200, 45);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1390, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "取得KAN-SEN数";
            // 
            // getCountLabel
            // 
            this.getCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getCountLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.getCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.getCountLabel.Location = new System.Drawing.Point(1371, 36);
            this.getCountLabel.Name = "getCountLabel";
            this.getCountLabel.Size = new System.Drawing.Size(200, 24);
            this.getCountLabel.TabIndex = 14;
            this.getCountLabel.Text = "0/0";
            this.getCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(1441, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "限界突破数";
            // 
            // limitBreakCountLabel
            // 
            this.limitBreakCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.limitBreakCountLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.limitBreakCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limitBreakCountLabel.Location = new System.Drawing.Point(1371, 84);
            this.limitBreakCountLabel.Name = "limitBreakCountLabel";
            this.limitBreakCountLabel.Size = new System.Drawing.Size(200, 24);
            this.limitBreakCountLabel.TabIndex = 16;
            this.limitBreakCountLabel.Text = "0/0";
            this.limitBreakCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(1441, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "認識覚醒数";
            // 
            // awakenCountLabel
            // 
            this.awakenCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.awakenCountLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.awakenCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.awakenCountLabel.Location = new System.Drawing.Point(1371, 132);
            this.awakenCountLabel.Name = "awakenCountLabel";
            this.awakenCountLabel.Size = new System.Drawing.Size(200, 24);
            this.awakenCountLabel.TabIndex = 18;
            this.awakenCountLabel.Text = "0/0";
            this.awakenCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(1489, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "改造数";
            // 
            // remodeledCountLabel
            // 
            this.remodeledCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remodeledCountLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.remodeledCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remodeledCountLabel.Location = new System.Drawing.Point(1371, 180);
            this.remodeledCountLabel.Name = "remodeledCountLabel";
            this.remodeledCountLabel.Size = new System.Drawing.Size(200, 24);
            this.remodeledCountLabel.TabIndex = 20;
            this.remodeledCountLabel.Text = "0/0";
            this.remodeledCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(1513, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "愛数";
            // 
            // loveCountLabel
            // 
            this.loveCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loveCountLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loveCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loveCountLabel.Location = new System.Drawing.Point(1371, 228);
            this.loveCountLabel.Name = "loveCountLabel";
            this.loveCountLabel.Size = new System.Drawing.Size(200, 24);
            this.loveCountLabel.TabIndex = 22;
            this.loveCountLabel.Text = "0/0";
            this.loveCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(1400, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "ストーリー完了数";
            // 
            // storyCompleteCountLabel
            // 
            this.storyCompleteCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.storyCompleteCountLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.storyCompleteCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.storyCompleteCountLabel.Location = new System.Drawing.Point(1371, 276);
            this.storyCompleteCountLabel.Name = "storyCompleteCountLabel";
            this.storyCompleteCountLabel.Size = new System.Drawing.Size(200, 24);
            this.storyCompleteCountLabel.TabIndex = 24;
            this.storyCompleteCountLabel.Text = "0/0";
            this.storyCompleteCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // getKANSEN
            // 
            this.getKANSEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getKANSEN.Location = new System.Drawing.Point(1156, 63);
            this.getKANSEN.Name = "getKANSEN";
            this.getKANSEN.Size = new System.Drawing.Size(200, 45);
            this.getKANSEN.TabIndex = 25;
            this.getKANSEN.Text = "KAN-SEN取得";
            this.getKANSEN.UseVisualStyleBackColor = true;
            this.getKANSEN.Click += new System.EventHandler(this.GetKANSENClick);
            // 
            // nameFilter
            // 
            this.nameFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameFilter.Location = new System.Drawing.Point(1362, 420);
            this.nameFilter.Name = "nameFilter";
            this.nameFilter.Size = new System.Drawing.Size(200, 45);
            this.nameFilter.TabIndex = 26;
            this.nameFilter.Text = "名前でフィルター";
            this.nameFilter.UseVisualStyleBackColor = true;
            this.nameFilter.Click += new System.EventHandler(this.NameFilterClick);
            // 
            // filterReset
            // 
            this.filterReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterReset.Location = new System.Drawing.Point(1362, 318);
            this.filterReset.Name = "filterReset";
            this.filterReset.Size = new System.Drawing.Size(200, 45);
            this.filterReset.TabIndex = 27;
            this.filterReset.Text = "フィルターをリセット";
            this.filterReset.UseVisualStyleBackColor = true;
            this.filterReset.Click += new System.EventHandler(this.FilterResetClick);
            // 
            // notThreeFilter
            // 
            this.notThreeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notThreeFilter.Location = new System.Drawing.Point(1362, 573);
            this.notThreeFilter.Name = "notThreeFilter";
            this.notThreeFilter.Size = new System.Drawing.Size(200, 45);
            this.notThreeFilter.TabIndex = 28;
            this.notThreeFilter.Text = "3回突破していない";
            this.notThreeFilter.UseVisualStyleBackColor = true;
            this.notThreeFilter.Click += new System.EventHandler(this.NotThreeFilterClick);
            // 
            // notAwakenFilter
            // 
            this.notAwakenFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notAwakenFilter.Location = new System.Drawing.Point(1362, 624);
            this.notAwakenFilter.Name = "notAwakenFilter";
            this.notAwakenFilter.Size = new System.Drawing.Size(200, 45);
            this.notAwakenFilter.TabIndex = 29;
            this.notAwakenFilter.Text = "認識覚醒済でない";
            this.notAwakenFilter.UseVisualStyleBackColor = true;
            this.notAwakenFilter.Click += new System.EventHandler(this.NotAwakenFilterClick);
            // 
            // notRemodeledFilter
            // 
            this.notRemodeledFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notRemodeledFilter.Location = new System.Drawing.Point(1362, 675);
            this.notRemodeledFilter.Name = "notRemodeledFilter";
            this.notRemodeledFilter.Size = new System.Drawing.Size(200, 45);
            this.notRemodeledFilter.TabIndex = 30;
            this.notRemodeledFilter.Text = "改造済でない";
            this.notRemodeledFilter.UseVisualStyleBackColor = true;
            this.notRemodeledFilter.Click += new System.EventHandler(this.NotRemodeledFilterClick);
            // 
            // notLoveFilter
            // 
            this.notLoveFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notLoveFilter.Location = new System.Drawing.Point(1362, 726);
            this.notLoveFilter.Name = "notLoveFilter";
            this.notLoveFilter.Size = new System.Drawing.Size(200, 45);
            this.notLoveFilter.TabIndex = 31;
            this.notLoveFilter.Text = "愛でない";
            this.notLoveFilter.UseVisualStyleBackColor = true;
            this.notLoveFilter.Click += new System.EventHandler(this.NotLoveFilterClick);
            // 
            // notStoryCompleteFilter
            // 
            this.notStoryCompleteFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notStoryCompleteFilter.Location = new System.Drawing.Point(1362, 777);
            this.notStoryCompleteFilter.Name = "notStoryCompleteFilter";
            this.notStoryCompleteFilter.Size = new System.Drawing.Size(200, 45);
            this.notStoryCompleteFilter.TabIndex = 32;
            this.notStoryCompleteFilter.Text = "ストーリー未完";
            this.notStoryCompleteFilter.UseVisualStyleBackColor = true;
            this.notStoryCompleteFilter.Click += new System.EventHandler(this.NotStoryCompleteFilterClick);
            // 
            // notGetsFilter
            // 
            this.notGetsFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notGetsFilter.Location = new System.Drawing.Point(1362, 471);
            this.notGetsFilter.Name = "notGetsFilter";
            this.notGetsFilter.Size = new System.Drawing.Size(200, 45);
            this.notGetsFilter.TabIndex = 33;
            this.notGetsFilter.Text = "取得していない";
            this.notGetsFilter.UseVisualStyleBackColor = true;
            this.notGetsFilter.Click += new System.EventHandler(this.NotGetsFilterClick);
            // 
            // sortByBreakInc
            // 
            this.sortByBreakInc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortByBreakInc.Location = new System.Drawing.Point(1156, 675);
            this.sortByBreakInc.Name = "sortByBreakInc";
            this.sortByBreakInc.Size = new System.Drawing.Size(200, 45);
            this.sortByBreakInc.TabIndex = 34;
            this.sortByBreakInc.Text = "突破ソート(昇順)";
            this.sortByBreakInc.UseVisualStyleBackColor = true;
            this.sortByBreakInc.Click += new System.EventHandler(this.SortByBreakIncClick);
            // 
            // sortByBreakDec
            // 
            this.sortByBreakDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortByBreakDec.Location = new System.Drawing.Point(1156, 726);
            this.sortByBreakDec.Name = "sortByBreakDec";
            this.sortByBreakDec.Size = new System.Drawing.Size(200, 45);
            this.sortByBreakDec.TabIndex = 35;
            this.sortByBreakDec.Text = "突破ソート(降順)";
            this.sortByBreakDec.UseVisualStyleBackColor = true;
            this.sortByBreakDec.Click += new System.EventHandler(this.SortByBreakDecClick);
            // 
            // getsFilter
            // 
            this.getsFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getsFilter.Location = new System.Drawing.Point(1362, 522);
            this.getsFilter.Name = "getsFilter";
            this.getsFilter.Size = new System.Drawing.Size(200, 45);
            this.getsFilter.TabIndex = 36;
            this.getsFilter.Text = "取得済み";
            this.getsFilter.UseVisualStyleBackColor = true;
            this.getsFilter.Click += new System.EventHandler(this.GetsFilterClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.getsFilter);
            this.Controls.Add(this.sortByBreakDec);
            this.Controls.Add(this.sortByBreakInc);
            this.Controls.Add(this.notGetsFilter);
            this.Controls.Add(this.notStoryCompleteFilter);
            this.Controls.Add(this.notLoveFilter);
            this.Controls.Add(this.notRemodeledFilter);
            this.Controls.Add(this.notAwakenFilter);
            this.Controls.Add(this.notThreeFilter);
            this.Controls.Add(this.filterReset);
            this.Controls.Add(this.nameFilter);
            this.Controls.Add(this.getKANSEN);
            this.Controls.Add(this.storyCompleteCountLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.loveCountLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.remodeledCountLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.awakenCountLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.limitBreakCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CompleteStory);
            this.Controls.Add(this.AddStory);
            this.Controls.Add(this.LoveSet);
            this.Controls.Add(this.Remodeled);
            this.Controls.Add(this.ImplementRemodel);
            this.Controls.Add(this.AwakenSet);
            this.Controls.Add(this.SetLimit);
            this.Controls.Add(this.addKANSEN);
            this.Controls.Add(this.KANSENDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.KANSENDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView KANSENDataGrid;
        private System.Windows.Forms.Button addKANSEN;
        private System.Windows.Forms.Button SetLimit;
        private System.Windows.Forms.Button AwakenSet;
        private System.Windows.Forms.Button ImplementRemodel;
        private System.Windows.Forms.Button Remodeled;
        private System.Windows.Forms.Button LoveSet;
        private System.Windows.Forms.Button AddStory;
        private System.Windows.Forms.Button CompleteStory;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label getCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label limitBreakCountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label awakenCountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label remodeledCountLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label loveCountLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label storyCompleteCountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn KANSENName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gets;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimitBreak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Awaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Love;
        private System.Windows.Forms.DataGridViewTextBoxColumn Story;
        private System.Windows.Forms.Button getKANSEN;
        private System.Windows.Forms.Button nameFilter;
        private System.Windows.Forms.Button filterReset;
        private System.Windows.Forms.Button notThreeFilter;
        private System.Windows.Forms.Button notAwakenFilter;
        private System.Windows.Forms.Button notRemodeledFilter;
        private System.Windows.Forms.Button notLoveFilter;
        private System.Windows.Forms.Button notStoryCompleteFilter;
        private System.Windows.Forms.Button notGetsFilter;
        private System.Windows.Forms.Button sortByBreakInc;
        private System.Windows.Forms.Button sortByBreakDec;
        private System.Windows.Forms.Button getsFilter;
    }
}

