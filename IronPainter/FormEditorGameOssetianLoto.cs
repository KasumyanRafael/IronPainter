using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace IronPainter
{
    public partial class FormEditorGameOssetianLoto : Form
    {
        OpenFileDialog ofd;
        public FormEditorGameOssetianLoto()
        {
            InitializeComponent();
        }
        PrivateFontCollection font;
        public void fontsProjects()
        {
            //Добавляем шрифт из указанного файла в em.Drawing.Text.PrivateFontCollection
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("font/BureauAP.ttf");
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
            TextBox[] words = {textBoxRussianWord,textBoxOssetianWord };
            PictureBox[]pictures ={pictureBoxRussian,pictureBoxOssetian};
            for (int i = 0; i < words.Length; i++)
            {
                CreateCard(words[i],pictures[i],pictureBoxMainPicture.Image,50,190);
            }
            CreateCard(words[1],pictureBoxWordWithoutImage,Properties.Resources.pwhite,50,100);
        }
        public void CreateCard(TextBox output, PictureBox input,Image img,int x,int y)
        {
            input.Image = img;
            Image image = input.Image;
            Graphics gr = Graphics.FromImage(image);
            gr.DrawString(output.Text,
            new System.Drawing.Font("BureauAP", 22, FontStyle.Regular),
            new SolidBrush(Color.Black), new RectangleF(x, y, 200, 340),
            new StringFormat(StringFormatFlags.NoWrap));
            input.Image = image;
        }
        private void buttonReturnToMenu_Click_1(object sender, EventArgs e)
        {
            FormMenu menu=new FormMenu();
            menu.Show();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonErasor_Click(object sender, EventArgs e)
        {
            PictureBox[] pictures = { pictureBoxRussian, pictureBoxOssetian,pictureBoxWordWithoutImage };
            for (int i = 0; i < pictures.Length; i++)
            {
                pictures[i].Image = null;
            }
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Новая папка Лото");
            string filename = "file1.png";
            string path = Directory.GetCurrentDirectory();
            if (!Directory.Exists(path + "/Новая папка Лото"))
            {
                Directory.CreateDirectory(path + "/Новая папка Лото");
            }
            File.Create(path + "/Новая папка Лото/" + filename);
            MessageBox.Show("Всё успешно сохранено");
        }
    }
}
