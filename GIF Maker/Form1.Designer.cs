namespace GIF_Maker
{
    partial class GIFMaker
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
            this.ImageOpenBtn = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.imageUpBtn = new System.Windows.Forms.Button();
            this.imageDownBtn = new System.Windows.Forms.Button();
            this.imageDisplayBox = new System.Windows.Forms.PictureBox();
            this.createGIFBtn = new System.Windows.Forms.Button();
            this.deleteAllImages = new System.Windows.Forms.Button();
            this.framePreviewLbl = new System.Windows.Forms.Label();
            this.ReplaceImageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageOpenBtn
            // 
            this.ImageOpenBtn.Location = new System.Drawing.Point(32, 65);
            this.ImageOpenBtn.Name = "ImageOpenBtn";
            this.ImageOpenBtn.Size = new System.Drawing.Size(175, 65);
            this.ImageOpenBtn.TabIndex = 0;
            this.ImageOpenBtn.Text = "Open Images";
            this.ImageOpenBtn.UseVisualStyleBackColor = true;
            this.ImageOpenBtn.Click += new System.EventHandler(this.ImageOpenBtn_Click);
            // 
            // imageList
            // 
            this.imageList.FormattingEnabled = true;
            this.imageList.ItemHeight = 20;
            this.imageList.Location = new System.Drawing.Point(248, 21);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(352, 304);
            this.imageList.TabIndex = 1;
            this.imageList.SelectedIndexChanged += new System.EventHandler(this.imageList_SelectedIndexChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(208, 350);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(151, 55);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // imageUpBtn
            // 
            this.imageUpBtn.Location = new System.Drawing.Point(391, 350);
            this.imageUpBtn.Name = "imageUpBtn";
            this.imageUpBtn.Size = new System.Drawing.Size(86, 55);
            this.imageUpBtn.TabIndex = 3;
            this.imageUpBtn.Text = "^";
            this.imageUpBtn.UseVisualStyleBackColor = true;
            this.imageUpBtn.Click += new System.EventHandler(this.imageUpBtn_Click);
            // 
            // imageDownBtn
            // 
            this.imageDownBtn.Location = new System.Drawing.Point(503, 350);
            this.imageDownBtn.Name = "imageDownBtn";
            this.imageDownBtn.Size = new System.Drawing.Size(86, 55);
            this.imageDownBtn.TabIndex = 4;
            this.imageDownBtn.Text = "v";
            this.imageDownBtn.UseVisualStyleBackColor = true;
            this.imageDownBtn.Click += new System.EventHandler(this.imageDownBtn_Click);
            // 
            // imageDisplayBox
            // 
            this.imageDisplayBox.Location = new System.Drawing.Point(669, 126);
            this.imageDisplayBox.Name = "imageDisplayBox";
            this.imageDisplayBox.Size = new System.Drawing.Size(247, 114);
            this.imageDisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDisplayBox.TabIndex = 5;
            this.imageDisplayBox.TabStop = false;
            // 
            // createGIFBtn
            // 
            this.createGIFBtn.Location = new System.Drawing.Point(780, 449);
            this.createGIFBtn.Name = "createGIFBtn";
            this.createGIFBtn.Size = new System.Drawing.Size(175, 54);
            this.createGIFBtn.TabIndex = 6;
            this.createGIFBtn.Text = "Create GIF";
            this.createGIFBtn.UseVisualStyleBackColor = true;
            this.createGIFBtn.Click += new System.EventHandler(this.createGIFBtn_Click);
            // 
            // deleteAllImages
            // 
            this.deleteAllImages.Location = new System.Drawing.Point(208, 420);
            this.deleteAllImages.Name = "deleteAllImages";
            this.deleteAllImages.Size = new System.Drawing.Size(151, 55);
            this.deleteAllImages.TabIndex = 7;
            this.deleteAllImages.Text = "delete all";
            this.deleteAllImages.UseVisualStyleBackColor = true;
            this.deleteAllImages.Click += new System.EventHandler(this.deleteAllImages_Click);
            // 
            // framePreviewLbl
            // 
            this.framePreviewLbl.AutoSize = true;
            this.framePreviewLbl.Location = new System.Drawing.Point(734, 87);
            this.framePreviewLbl.Name = "framePreviewLbl";
            this.framePreviewLbl.Size = new System.Drawing.Size(117, 20);
            this.framePreviewLbl.TabIndex = 8;
            this.framePreviewLbl.Text = "Frame Preview:";
            // 
            // ReplaceImageBtn
            // 
            this.ReplaceImageBtn.Location = new System.Drawing.Point(391, 420);
            this.ReplaceImageBtn.Name = "ReplaceImageBtn";
            this.ReplaceImageBtn.Size = new System.Drawing.Size(151, 55);
            this.ReplaceImageBtn.TabIndex = 10;
            this.ReplaceImageBtn.Text = "Replace Image";
            this.ReplaceImageBtn.UseVisualStyleBackColor = true;
            this.ReplaceImageBtn.Click += new System.EventHandler(this.ReplaceImageBtn_Click);
            // 
            // GIFMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 515);
            this.Controls.Add(this.ReplaceImageBtn);
            this.Controls.Add(this.framePreviewLbl);
            this.Controls.Add(this.deleteAllImages);
            this.Controls.Add(this.createGIFBtn);
            this.Controls.Add(this.imageDisplayBox);
            this.Controls.Add(this.imageDownBtn);
            this.Controls.Add(this.imageUpBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.ImageOpenBtn);
            this.Name = "GIFMaker";
            this.Text = "GIF Maker";
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImageOpenBtn;
        private System.Windows.Forms.ListBox imageList;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button imageUpBtn;
        private System.Windows.Forms.Button imageDownBtn;
        private System.Windows.Forms.PictureBox imageDisplayBox;
        private System.Windows.Forms.Button createGIFBtn;
        private System.Windows.Forms.Button deleteAllImages;
        private System.Windows.Forms.Label framePreviewLbl;
        private System.Windows.Forms.Button ReplaceImageBtn;
    }
}

