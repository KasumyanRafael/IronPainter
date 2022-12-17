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
    public partial class FormEditorGameTrain : Form
    {
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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP; *.JPG;*.PNG)|*.BMP;*.JPG;*PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxMain.Image = new Bitmap(ofd.FileName);
                }
                catch
                {

                    MessageBox.Show("Невозможно выбрать данный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            pictureBoxArmenianTrain.Image = Properties.Resources.FilledWagon;
            pictureBoxGeorgianTrain.Image= Properties.Resources.FilledWagon;
            pictureBoxOssetianTrain.Image=Properties.Resources.FilledWagon;
            labelOs.Text=textBoxOssetianWord.Text;
            labelAm.Text=textBoxArmenianWord.Text;
            labelGe.Text=textBoxGeorgianWord.Text;

        }
    }
}
