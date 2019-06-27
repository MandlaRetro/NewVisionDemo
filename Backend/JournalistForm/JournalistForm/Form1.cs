using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;
namespace JournalistForm {
    public partial class CMS : Form {
        public CMS() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImageDisplay.Hide();
        }

        private void PictureUpload_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            ImageDisplay.Show();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    ImageDisplay.Image = new Bitmap(filePath);
                    ImageDisplay.ImageLocation = filePath;
                    ImageDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void Image_Click(object sender, EventArgs e)
        {

        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            try {
                NpgsqlConnection conn = new NpgsqlConnection("User ID = postgres;Password=postgres;Server=localhost;Port=5432;Database=Demo;Integrated Security=true;Pooling=true;");
                conn.Open();
                using (NpgsqlCommand cmd = conn.CreateCommand()) {
                    cmd.CommandText = @"insert into ""Articles""(""Content"",""Author"",""Title"",""ImageBase64"",""UploadDate"")
                        values(@Content, @Author, @Title, @ImageBase64, @UploadDate)";
                    cmd.Parameters.Add(new NpgsqlParameter("@Content", Content.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Title", Headline.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Author", Author.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@ImageBase64", ToBase64(ImageDisplay.ImageLocation)));
                    cmd.Parameters.Add(new NpgsqlParameter("@UploadDate", DateTime.Now));
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show("Succesfully published", "Published");
            } catch (Exception) {
                MessageBox.Show("Could not publish article. Try again", "Error");
            }
        }

        private void Author_TextChanged(object sender, EventArgs e)
        {

        }

        private string ToBase64(string imagePath) {
            if (imagePath == null || imagePath == "") return "";
            byte[] imageBytes = File.ReadAllBytes(imagePath);
            return Convert.ToBase64String(imageBytes);
        }

        private void Content_TextChanged(object sender, EventArgs e) {

        }

        private void Headline_Label_Click(object sender, EventArgs e) {

        }

        private void Headline_TextChanged(object sender, EventArgs e) {

        }

        private void Author_Label_Click(object sender, EventArgs e) {

        }

        private void Article_Label_Click(object sender, EventArgs e) {

        }
    }
}
