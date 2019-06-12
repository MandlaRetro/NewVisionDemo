using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Npgsql;
namespace JournalistForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("User ID = postgres;Password=postgres;Server=localhost;Port=5432;Database=Demo;Integrated Security=true;Pooling=true;");
            conn.Open();
            using (NpgsqlCommand cmd = conn.CreateCommand()) {
                cmd.CommandText = @"insert into ""Articles""(""Content"",""Title"",""Author"",""ImageBase64"")
                    values(@Content, @Author, @Title, @ImageBase64)";
                cmd.Parameters.Add(new NpgsqlParameter("@Content", Content.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@Title", Title.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@Author", Author.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@ImageBase64", ToBase64(ImageDisplay.ImageLocation)));
                cmd.ExecuteNonQuery();
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private string ToBase64(string imagePath) {
            byte[] imageBytes = File.ReadAllBytes(imagePath);
            return Convert.ToBase64String(imageBytes);
        }

        private void Content_TextChanged(object sender, EventArgs e) {

        }
    }
}
