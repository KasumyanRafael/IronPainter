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
            string rusword=textBoxRussianWord.Text;
            string ironword=textBoxOssetianWord.Text;
            if (pictureBoxMainPicture == null)
            {
                MessageBox.Show("Вы не выбрали исходную картинку. Невозможно создать карточки!");
            }
            else
            {
                pictureBoxRussian.Image = new Bitmap(ofd.FileName);
                pictureBoxOssetian.Image = new Bitmap(ofd.FileName);
            }
            if (rusword=="Русское"&&ironword=="Осетинское")
            {
                MessageBox.Show("Вы не вписали слова в поля. Невозможно создать карточки!");
            }
            else
            {
                labelRus.Text = textBoxRussianWord.Text;
                labelIron.Text = textBoxOssetianWord.Text;
                labelIronWord.Text = textBoxOssetianWord.Text;
                
            }
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void buttonReturnToMenu_Click_1(object sender, EventArgs e)
        {
            FormMenu menu=new FormMenu();
            menu.Show();
        }
    }
}
