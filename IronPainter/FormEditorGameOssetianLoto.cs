using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace IronPainter
{
    public partial class FormEditorGameOssetianLoto : Form
    {
        OpenFileDialog ofd;
        public Dictionary<string,int>categories=new Dictionary<string,int>();
        public FormEditorGameOssetianLoto()
        {
            InitializeComponent();
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
            if(pictureBoxMainPicture.Image != null) buttonResult.Enabled = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            TextBox[] words = { textBoxRussianWord, textBoxOssetianWord };
            PictureBox[] pictures = { pictureBoxRussian, pictureBoxOssetian };
            for (int i = 0; i < words.Length; i++)
            {
                CreateCard(words[i], pictures[i], pictureBoxMainPicture.Image, 50, 190);
            }
            CreateCard(words[1], pictureBoxWordWithoutImage, Properties.Resources.pwhite, 50, 100);
            if(IsFilled(pictures,pictureBoxWordWithoutImage))
            {
                buttonSaveResult.Enabled = true;
            }
        }
        public bool IsFilled(PictureBox[]pictures,PictureBox picture)
        {
            for (int i = 0; i < pictures.Length; i++)
            {
                if (pictures[i].Image != null && picture.Image != null)
                    return true;
            }
            return false;
        }
        public void CreateCard(TextBox output, PictureBox input, Image img, int x, int y)
        {
            input.Image = img;
            Image image = input.Image;
            Graphics gr = Graphics.FromImage(image);
            gr.DrawString(output.Text,
            new System.Drawing.Font("BureauAP", 22, FontStyle.Regular),
            new SolidBrush(Color.Black), new RectangleF(x, y, 200, 340),
            new StringFormat(StringFormatFlags.NoWrap));
            input.Image = image;
            gr = null;
        }
        private void buttonReturnToMenu_Click_1(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonErasor_Click(object sender, EventArgs e)
        {
            PictureBox[] pictures = { pictureBoxMainPicture,pictureBoxRussian, pictureBoxOssetian, pictureBoxWordWithoutImage };
            for (int i = 0; i < pictures.Length; i++)
            {
                pictures[i].Image = null;
            }
            buttonSaveResult.Enabled = false;
            buttonResult.Enabled = false;
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            string category=comboBoxInnerThemes.Text;
            if (category == String.Empty) MessageBox.Show("Выберите категорию");
            else
            {
                StreamReader file = new StreamReader("lotoPictureId.txt");
                int cardId = Convert.ToInt32(file.ReadLine());
                file.Close();
                PictureBox[] pictures = { pictureBoxMainPicture, pictureBoxRussian, pictureBoxOssetian, pictureBoxWordWithoutImage };
                TextBox[] words = { textBoxRussianWord, textBoxOssetianWord };
                SaveImages(pictures, cardId,categories[category],words);
                cardId++;
                StreamWriter thisfile = new StreamWriter("lotoPictureId.txt");
                thisfile.WriteLine(cardId);
                thisfile.Close();
                MessageBox.Show("Всё успешно сохранено!");
                FormMenu form = new FormMenu();
                form.Show();
                this.Hide();
            }            
        }
        public void SaveImages(PictureBox[] pictures,int num,int category,TextBox[]words)
        {
            List<string>filenames = new List<string>();
            string numberOfCategory;
            for (int i = 0; i < pictures.Length; i++)
            {
                if(category<10)
                {
                    numberOfCategory = String.Format("0{0}",category);
                }
                else
                {
                    numberOfCategory=category.ToString();
                }
                string filename = String.Format("p{0}type{1}cat{2}Loto.bmp",num,i,numberOfCategory);
                filenames.Add(filename);
                pictures[i].Image.Save(filename);
            }
            StreamWriter file = new StreamWriter(String.Format("p{0}words.txt", num));
            for (int i = 0; i < words.Length; i++)
            {
                file.WriteLine(words[i].Text);
            }
            file.Close();
        }

        private void FormEditorGameOssetianLoto_Load(object sender, EventArgs e)
        {
            string[] items = Properties.Resources.inner_categories.Split('\n');
            comboBoxInnerThemes.Items.AddRange(items);
        }
    }
}
