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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonEditorGameTrain_Click(object sender, EventArgs e)
        {
            FormEditorGameTrain formEditorGameTrain = new FormEditorGameTrain();
            this.Hide();
            formEditorGameTrain.Show();
        }

        private void buttonEditorGameOssetianLoto_Click(object sender, EventArgs e)
        {
            FormEditorGameOssetianLoto formEditorGameOssetianLoto = new FormEditorGameOssetianLoto();
            this.Hide();
            formEditorGameOssetianLoto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
