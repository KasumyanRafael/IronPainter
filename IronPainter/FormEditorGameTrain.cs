using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronPainter
{
    public partial class FormEditorGameTrain : Form
    {
        public TextBox[] words;
        public PictureBox[] wagons;
        public PictureBox[] pictures;
        public FormEditorGameTrain()
        {
            InitializeComponent();
        }

        private void FormEditorGameTrain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonSelection_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            FormEditorGameTrainResults formEditorGameTrainResults = new FormEditorGameTrainResults();
            this.Hide();
            formEditorGameTrainResults.Show();
            words = new TextBox[4]{textBoxRussianWord,textBoxOssetianWord, textBoxArmenianWord,textBoxGeorgianWord};
           
        }
        
        private void buttonErasor_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Всё успешно сохранено");
            Directory.CreateDirectory("Новая папка Train");
        }

        private void textBoxRussianWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelection_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP; *.JPG;*.PNG)|*.BMP;*.JPG;*PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox.Image = new Bitmap(ofd.FileName);
                }
                catch
                {

                    MessageBox.Show("Невозможно выбрать данный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
