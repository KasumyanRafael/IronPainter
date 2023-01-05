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

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            FormMenu frm=new FormMenu();
            frm.Show();
            this.Hide();
        }
    }
}
