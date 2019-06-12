namespace JournalistForm {
    partial class Form1 {
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
            this.Title = new System.Windows.Forms.RichTextBox();
            this.Author = new System.Windows.Forms.TextBox();
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
            this.ImageDisplay.Size = new System.Drawing.Size(263, 123);
            this.ImageDisplay.TabIndex = 1;
            this.ImageDisplay.TabStop = false;
            this.ImageDisplay.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(12, 105);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(240, 30);
            this.Title.TabIndex = 5;
            this.Title.Text = "";
            this.Title.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(12, 46);
            this.Author.Multiline = true;
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(331, 24);
            this.Author.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.PictureUpload);
            this.Controls.Add(this.ImageDisplay);
            this.Controls.Add(this.UploadButton);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.RichTextBox Title;
        private System.Windows.Forms.TextBox Author;
    }
}

