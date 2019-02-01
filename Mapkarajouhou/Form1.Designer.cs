namespace Mapkarajouhou
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.fullTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLayoutPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.bookmarkButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weatherText = new System.Windows.Forms.ListBox();
            this.weatherPicture = new System.Windows.Forms.PictureBox();
            this.tweetButton = new System.Windows.Forms.Button();
            this.weatherButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookmarkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullTableLayout.SuspendLayout();
            this.leftTableLayout.SuspendLayout();
            this.buttonLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullTableLayout
            // 
            this.fullTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullTableLayout.ColumnCount = 2;
            this.fullTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.fullTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.fullTableLayout.Controls.Add(this.leftTableLayout, 0, 0);
            this.fullTableLayout.Controls.Add(this.panel1, 1, 0);
            this.fullTableLayout.Location = new System.Drawing.Point(12, 27);
            this.fullTableLayout.Name = "fullTableLayout";
            this.fullTableLayout.RowCount = 1;
            this.fullTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fullTableLayout.Size = new System.Drawing.Size(960, 522);
            this.fullTableLayout.TabIndex = 0;
            // 
            // leftTableLayout
            // 
            this.leftTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftTableLayout.ColumnCount = 1;
            this.leftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftTableLayout.Controls.Add(this.buttonLayoutPanel, 0, 1);
            this.leftTableLayout.Location = new System.Drawing.Point(3, 3);
            this.leftTableLayout.Name = "leftTableLayout";
            this.leftTableLayout.RowCount = 2;
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.leftTableLayout.Size = new System.Drawing.Size(666, 516);
            this.leftTableLayout.TabIndex = 1;
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLayoutPanel.Controls.Add(this.searchButton);
            this.buttonLayoutPanel.Controls.Add(this.bookmarkButton);
            this.buttonLayoutPanel.Location = new System.Drawing.Point(3, 471);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.Size = new System.Drawing.Size(660, 42);
            this.buttonLayoutPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(582, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bookmarkButton.Enabled = false;
            this.bookmarkButton.Location = new System.Drawing.Point(3, 12);
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(99, 23);
            this.bookmarkButton.TabIndex = 0;
            this.bookmarkButton.Text = "ブックマーク";
            this.bookmarkButton.UseVisualStyleBackColor = true;
            this.bookmarkButton.Click += new System.EventHandler(this.bookmarkButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.weatherText);
            this.panel1.Controls.Add(this.weatherPicture);
            this.panel1.Controls.Add(this.tweetButton);
            this.panel1.Controls.Add(this.weatherButton);
            this.panel1.Location = new System.Drawing.Point(675, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 516);
            this.panel1.TabIndex = 2;
            // 
            // weatherText
            // 
            this.weatherText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weatherText.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.weatherText.FormattingEnabled = true;
            this.weatherText.ItemHeight = 20;
            this.weatherText.Location = new System.Drawing.Point(3, 133);
            this.weatherText.Name = "weatherText";
            this.weatherText.Size = new System.Drawing.Size(276, 324);
            this.weatherText.TabIndex = 6;
            // 
            // weatherPicture
            // 
            this.weatherPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weatherPicture.Location = new System.Drawing.Point(3, 3);
            this.weatherPicture.Name = "weatherPicture";
            this.weatherPicture.Size = new System.Drawing.Size(276, 125);
            this.weatherPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherPicture.TabIndex = 5;
            this.weatherPicture.TabStop = false;
            // 
            // tweetButton
            // 
            this.tweetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tweetButton.Location = new System.Drawing.Point(204, 484);
            this.tweetButton.Name = "tweetButton";
            this.tweetButton.Size = new System.Drawing.Size(75, 21);
            this.tweetButton.TabIndex = 4;
            this.tweetButton.Text = "ツイート";
            this.tweetButton.UseVisualStyleBackColor = true;
            this.tweetButton.Click += new System.EventHandler(this.tweetButton_Click);
            // 
            // weatherButton
            // 
            this.weatherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.weatherButton.Location = new System.Drawing.Point(3, 482);
            this.weatherButton.Name = "weatherButton";
            this.weatherButton.Size = new System.Drawing.Size(92, 23);
            this.weatherButton.TabIndex = 1;
            this.weatherButton.Text = "ブラウザで見る";
            this.weatherButton.UseVisualStyleBackColor = true;
            this.weatherButton.Click += new System.EventHandler(this.weatherButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookmarkMenuItem
            // 
            this.bookmarkMenuItem.Name = "bookmarkMenuItem";
            this.bookmarkMenuItem.Size = new System.Drawing.Size(67, 20);
            this.bookmarkMenuItem.Text = "登録地点";
            this.bookmarkMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bookmarkMenuItemClicked);
            // 
            // Form1
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.fullTableLayout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "マップから選んだ場所の天気を取得";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.fullTableLayout.ResumeLayout(false);
            this.leftTableLayout.ResumeLayout(false);
            this.buttonLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel fullTableLayout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookmarkMenuItem;
        private System.Windows.Forms.TableLayoutPanel leftTableLayout;
        private System.Windows.Forms.Button weatherButton;
        private System.Windows.Forms.Panel buttonLayoutPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button bookmarkButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tweetButton;
        private System.Windows.Forms.PictureBox weatherPicture;
        private System.Windows.Forms.ListBox weatherText;
    }
}

