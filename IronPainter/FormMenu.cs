using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string[]categories= Properties.Resources.inner_categories.Split('\n'); 
            CreateFile("trainPictureId.txt");
            FormEditorGameTrain formEditorGameTrain = new FormEditorGameTrain();
            this.Hide();
            formEditorGameTrain.Show();
        }

        private void buttonEditorGameOssetianLoto_Click(object sender, EventArgs e)
        {
            string[] categories = Properties.Resources.inner_categories.Split('\n');
            CreateFile("lotoPictureId.txt");
            FormEditorGameOssetianLoto formEditorGameOssetianLoto = new FormEditorGameOssetianLoto();
            this.Hide();
            formEditorGameOssetianLoto.Show();
        }
        public void CreateFile(string path)
        {
            if (!File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path);
                file.WriteLine("0");
                file.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public Dictionary<int,string> CreateHashOfCats(string[]array)
        {
            Dictionary<int,string>hash= new Dictionary<int,string>();
            return hash;
        }
    }
}
