namespace Giphy_Downloader
{
    partial class Form1
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxGifName = new System.Windows.Forms.TextBox();
            this.labelGifName = new System.Windows.Forms.Label();
            this.pictureBoxGif1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGif4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGif2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGif3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(250, 20);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(105, 49);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxGifName
            // 
            this.textBoxGifName.Location = new System.Drawing.Point(17, 36);
            this.textBoxGifName.Name = "textBoxGifName";
            this.textBoxGifName.Size = new System.Drawing.Size(227, 26);
            this.textBoxGifName.TabIndex = 0;
            this.textBoxGifName.TextChanged += new System.EventHandler(this.textBoxGifName_TextChanged);
            this.textBoxGifName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGifName_KeyDown);
            // 
            // labelGifName
            // 
            this.labelGifName.AutoSize = true;
            this.labelGifName.Location = new System.Drawing.Point(13, 13);
            this.labelGifName.Name = "labelGifName";
            this.labelGifName.Size = new System.Drawing.Size(98, 20);
            this.labelGifName.TabIndex = 2;
            this.labelGifName.Text = "GIF\'s Name:";
            // 
            // pictureBoxGif1
            // 
            this.pictureBoxGif1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGif1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxGif1.Name = "pictureBoxGif1";
            this.pictureBoxGif1.Size = new System.Drawing.Size(294, 222);
            this.pictureBoxGif1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGif1.TabIndex = 3;
            this.pictureBoxGif1.TabStop = false;
            // 
            // pictureBoxGif4
            // 
            this.pictureBoxGif4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGif4.Location = new System.Drawing.Point(303, 231);
            this.pictureBoxGif4.Name = "pictureBoxGif4";
            this.pictureBoxGif4.Size = new System.Drawing.Size(294, 222);
            this.pictureBoxGif4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGif4.TabIndex = 4;
            this.pictureBoxGif4.TabStop = false;
            // 
            // pictureBoxGif2
            // 
            this.pictureBoxGif2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGif2.Location = new System.Drawing.Point(303, 3);
            this.pictureBoxGif2.Name = "pictureBoxGif2";
            this.pictureBoxGif2.Size = new System.Drawing.Size(294, 222);
            this.pictureBoxGif2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGif2.TabIndex = 5;
            this.pictureBoxGif2.TabStop = false;
            // 
            // pictureBoxGif3
            // 
            this.pictureBoxGif3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGif3.Location = new System.Drawing.Point(3, 231);
            this.pictureBoxGif3.Name = "pictureBoxGif3";
            this.pictureBoxGif3.Size = new System.Drawing.Size(294, 222);
            this.pictureBoxGif3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGif3.TabIndex = 6;
            this.pictureBoxGif3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxGif1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxGif4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxGif3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxGif2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 456);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelGifName);
            this.Controls.Add(this.textBoxGifName);
            this.Controls.Add(this.buttonShow);
            this.Name = "Form1";
            this.Text = "GIF Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxGifName;
        private System.Windows.Forms.Label labelGifName;
        private System.Windows.Forms.PictureBox pictureBoxGif1;
        private System.Windows.Forms.PictureBox pictureBoxGif4;
        private System.Windows.Forms.PictureBox pictureBoxGif2;
        private System.Windows.Forms.PictureBox pictureBoxGif3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

