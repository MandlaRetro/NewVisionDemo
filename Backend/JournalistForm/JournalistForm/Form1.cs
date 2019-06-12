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
            pictureBox1.Hide();
        }

        private void PictureUpload_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            pictureBox1.Show();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    pictureBox1.Image = new Bitmap(filePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
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
            //NpgsqlCommand cmd = conn.CreateCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = @"Insert into ""Articles"" values(@Id,@Content,@Title,@Author,@ImageBase64)";
            NpgsqlCommand cmd = new NpgsqlCommand(@"insert into ""Articles""(Id,Content,Title,Author,ImageBase64) values('" + richTextBox1.Text + "','" + Author.Text + "','" + richTextBox2.Text + "','" + pictureBox1 + "')", conn);
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add(new NpgsqlParameter("@Content", richTextBox1.Text));
            //cmd.Parameters.Add(new NpgsqlParameter("@Author", Author.Text));
            //cmd.Parameters.Add(new NpgsqlParameter("@Title", richTextBox2.Text));
            //cmd.Parameters.Add(new NpgsqlParameter("@ImageBase64", pictureBox1.Name));
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
