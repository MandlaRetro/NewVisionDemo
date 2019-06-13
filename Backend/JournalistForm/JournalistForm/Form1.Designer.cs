namespace JournalistForm {
    partial class CMS {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.UploadButton = new System.Windows.Forms.Button();
            this.ImageDisplay = new System.Windows.Forms.PictureBox();
            this.PictureUpload = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.Headline_Label = new System.Windows.Forms.Label();
            this.Author_Label = new System.Windows.Forms.Label();
            this.Article_Label = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.RichTextBox();
            this.Headline = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(476, 346);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(144, 44);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // ImageDisplay
            // 
            this.ImageDisplay.Location = new System.Drawing.Point(476, 12);
            this.ImageDisplay.Name = "ImageDisplay";
            this.ImageDisplay.Size = new System.Drawing.Size(299, 173);
            this.ImageDisplay.TabIndex = 1;
            this.ImageDisplay.TabStop = false;
            this.ImageDisplay.Click += new System.EventHandler(this.Image_Click);
            // 
            // PictureUpload
            // 
            this.PictureUpload.Location = new System.Drawing.Point(476, 214);
            this.PictureUpload.Name = "PictureUpload";
            this.PictureUpload.Size = new System.Drawing.Size(144, 44);
            this.PictureUpload.TabIndex = 3;
            this.PictureUpload.Text = "Picture";
            this.PictureUpload.UseVisualStyleBackColor = true;
            this.PictureUpload.Click += new System.EventHandler(this.PictureUpload_Click);
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(12, 214);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(351, 206);
            this.Content.TabIndex = 4;
            this.Content.Text = "";
            this.Content.TextChanged += new System.EventHandler(this.Content_TextChanged);
            // 
            // Headline_Label
            // 
            this.Headline_Label.AutoSize = true;
            this.Headline_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headline_Label.Location = new System.Drawing.Point(12, 12);
            this.Headline_Label.Name = "Headline_Label";
            this.Headline_Label.Size = new System.Drawing.Size(72, 19);
            this.Headline_Label.TabIndex = 7;
            this.Headline_Label.Text = "Headline";
            this.Headline_Label.Click += new System.EventHandler(this.Headline_Label_Click);
            // 
            // Author_Label
            // 
            this.Author_Label.AutoSize = true;
            this.Author_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_Label.Location = new System.Drawing.Point(13, 87);
            this.Author_Label.Name = "Author_Label";
            this.Author_Label.Size = new System.Drawing.Size(57, 19);
            this.Author_Label.TabIndex = 8;
            this.Author_Label.Text = "Author";
            this.Author_Label.Click += new System.EventHandler(this.Author_Label_Click);
            // 
            // Article_Label
            // 
            this.Article_Label.AutoSize = true;
            this.Article_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Article_Label.Location = new System.Drawing.Point(17, 178);
            this.Article_Label.Name = "Article_Label";
            this.Article_Label.Size = new System.Drawing.Size(55, 19);
            this.Article_Label.TabIndex = 9;
            this.Article_Label.Text = "Article";
            this.Article_Label.Click += new System.EventHandler(this.Article_Label_Click);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(12, 124);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(240, 25);
            this.Author.TabIndex = 5;
            this.Author.Text = "";
            this.Author.TextChanged += new System.EventHandler(this.Author_TextChanged);
            // 
            // Headline
            // 
            this.Headline.Location = new System.Drawing.Point(12, 44);
            this.Headline.Name = "Headline";
            this.Headline.Size = new System.Drawing.Size(351, 24);
            this.Headline.TabIndex = 10;
            this.Headline.Text = "";
            this.Headline.TextChanged += new System.EventHandler(this.Headline_TextChanged);
            // 
            // CMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Headline);
            this.Controls.Add(this.Article_Label);
            this.Controls.Add(this.Author_Label);
            this.Controls.Add(this.Headline_Label);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.PictureUpload);
            this.Controls.Add(this.ImageDisplay);
            this.Controls.Add(this.UploadButton);
            this.Name = "CMS";
            this.Text = "CMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.PictureBox ImageDisplay;
        private System.Windows.Forms.Button PictureUpload;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.Label Headline_Label;
        private System.Windows.Forms.Label Author_Label;
        private System.Windows.Forms.Label Article_Label;
        private System.Windows.Forms.RichTextBox Author;
        private System.Windows.Forms.RichTextBox Headline;
    }
}

