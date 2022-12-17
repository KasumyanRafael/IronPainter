using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronPainter
{
    public partial class FormEditorGameOssetianLoto : Form
    {
        OpenFileDialog ofd;
        public FormEditorGameOssetianLoto()
        {
            InitializeComponent();
        }

        private void FormEditorGameOssetianLoto_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonSelection_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP; *.JPG;*.PNG)|*.BMP;*.JPG;*PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxMainPicture.Image = new Bitmap(ofd.FileName);
                }
                catch
                {

                    MessageBox.Show("Невозможно выбрать данный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            pictureBoxRussian.Image = new Bitmap(ofd.FileName);
            pictureBoxOssetian.Image = new Bitmap(ofd.FileName);
            CreateCard(pictureBoxMainPicture,pictureBoxRussian,textBoxRussianWord,50,190);
            CreateCard(pictureBoxMainPicture, pictureBoxOssetian, textBoxOssetianWord, 50, 190);
            CreateWordCard(textBoxOssetianWord,pictureBoxWordWithoutImage);
        }


        private void buttonReturnToMenu_Click_1(object sender, EventArgs e)
        {
            FormMenu menu=new FormMenu();
            menu.Show();
        }
        public void CreateCard(PictureBox output,PictureBox input,TextBox txt,int a,int b)
        {
            Image img=output.Image;
            Graphics gr=Graphics.FromImage(img);
            gr.DrawString(txt.Text,
            new System.Drawing.Font("Arial", 22, FontStyle.Regular),
            new SolidBrush(Color.Black), new RectangleF(a, b, 200, 340),
            new StringFormat(StringFormatFlags.NoWrap));
            input.Image=img;
        }
        public void CreateWordCard(TextBox output,PictureBox input)
        {
            input.Image = Properties.Resources.pwhite;
            Image image=input.Image;
            Graphics gr= Graphics.FromImage(image);
            gr.DrawString(output.Text,
            new System.Drawing.Font("Arial", 22, FontStyle.Regular),
            new SolidBrush(Color.Black), new RectangleF(50, 100, 200, 340),
            new StringFormat(StringFormatFlags.NoWrap));
            input.Image = image;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
