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
    public partial class FormEditorGameTrainResults : Form
    {
        public Image mainImg;
        public string[] signs;
        public FormEditorGameTrainResults()
        {
            InitializeComponent();
        }
        public void CreateWagonCard(string output, PictureBox input)
        {
            Image image = Properties.Resources.FilledWagon;
            Graphics gr = Graphics.FromImage(image);
            gr.DrawString(output,
            new System.Drawing.Font("BureauAP", 76, FontStyle.Bold),
            new SolidBrush(Color.White), new RectangleF(370, 250, 1100, 340),
            new StringFormat(StringFormatFlags.NoWrap));
            input.Image = image;
        }
        public void CreateCard(string output, PictureBox input, Image img, int x, int y)
        {
            input.Image = img;
            Image image = input.Image;
            Graphics gr = Graphics.FromImage(image);
            gr.DrawString(output,
            new System.Drawing.Font("BureauAP", 22, FontStyle.Regular),
            new SolidBrush(Color.Black), new RectangleF(x, y, 200, 340),
            new StringFormat(StringFormatFlags.NoWrap));
            input.Image = image;
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            FormEditorGameTrain frm=new FormEditorGameTrain();
            frm.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormEditorGameTrainResults_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Image = mainImg;
            PictureBox[] wagons = { pictureBoxRussianTrain, pictureBoxOssetianTrain, pictureBoxArmenianTrain, pictureBoxGeorgianTrain };
            PictureBox[] pictures = { pictureBoxRussian, pictureBoxOssetian, pictureBoxArmenian, pictureBoxGeorgian };
            for (int i = 0; i < pictures.Length; i++)
            {
                CreateCard(signs[i], pictures[i], pictureBoxMain.Image, 50, 190);
                CreateWagonCard(signs[i], wagons[i]);
            }
        }
    }
}
