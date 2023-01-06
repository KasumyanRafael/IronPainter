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
OpenFileDialog ofd;
        public string[] signs = new string[4];
        public FormEditorGameTrain()
        {
            InitializeComponent();
        }
        


        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReturnToMenu_Click_1(object sender, EventArgs e)
        {
            FormMenu frm=new FormMenu();
            frm.Show();
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
            if (pictureBoxMainPicture.Image != null) buttonResult.Enabled = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
TextBox[] boxes = {textBoxRussianWord,textBoxOssetianWord,textBoxArmenianWord,textBoxGeorgianWord};
            FormEditorGameTrainResults frm=new FormEditorGameTrainResults();
            frm.Show();
            frm.mainImg = pictureBoxMainPicture.Image;
            frm.signs = ReadSigns(boxes);
            this.Hide();
        }
        public string [] ReadSigns(TextBox[]boxes)
        {
            string[]signs=new string[boxes.Length];
            for (int i = 0; i < boxes.Length; i++)
            {
                signs[i]=boxes[i].Text;
            }
            return signs;
        }
    }
}
