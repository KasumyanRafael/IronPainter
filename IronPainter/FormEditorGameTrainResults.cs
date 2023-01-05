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
        public FormEditorGameTrainResults()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            FormEditorGameTrain formEditorGameTrain = new FormEditorGameTrain();
            formEditorGameTrain.wagons = new PictureBox[]{ pictureBoxRussianTrain, pictureBoxOssetianTrain, pictureBoxArmenianTrain, pictureBoxGeorgianTrain };
            formEditorGameTrain.pictures = new PictureBox[]{ pictureBoxRussian, pictureBoxOssetian, pictureBoxArmenian, pictureBoxGeorgian };
            
            for (int i = 0; i < formEditorGameTrain.pictures.Length; i++)
            {
                CreateWagonCard(formEditorGameTrain.words[i], formEditorGameTrain.wagons[i]);
                CreateCard(formEditorGameTrain.words[i], formEditorGameTrain.pictures[i], pictureBoxRussian.Image, 50, 190);
            }
        }
        public void CreateWagonCard(TextBox output, PictureBox input)
        {
            input.Image = Properties.Resources.FilledWagon;
            Image image = input.Image;
            Graphics gr = Graphics.FromImage(image);
            gr.DrawString(output.Text,
            new System.Drawing.Font("BureauAP", 76, FontStyle.Bold),
            new SolidBrush(Color.White), new RectangleF(370, 250, 1100, 340),
            new StringFormat(StringFormatFlags.NoWrap));
            input.Image = image;
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
        }

        private void FormEditorGameTrainResults_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
