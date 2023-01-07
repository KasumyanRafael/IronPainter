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
        public Dictionary<string,int> hash = new Dictionary<string,int>();  
        public FormMenu()
        {
            InitializeComponent();
        }
        private void buttonEditorGameTrain_Click(object sender, EventArgs e)
        {
            string[]categories= Properties.Resources.inner_categories.Split('\n');
            hash=CreateHashOfCats(categories);
            CreateFile("trainPictureId.txt");
            FormEditorGameTrain formEditorGameTrain = new FormEditorGameTrain();
            formEditorGameTrain.categories = hash;
            formEditorGameTrain.Show();
            this.Hide();
        }

        private void buttonEditorGameOssetianLoto_Click(object sender, EventArgs e)
        {
            string[] categories = Properties.Resources.inner_categories.Split('\n');
            hash = CreateHashOfCats(categories);
            CreateFile("lotoPictureId.txt");
            FormEditorGameOssetianLoto formEditorGameOssetianLoto = new FormEditorGameOssetianLoto();
            formEditorGameOssetianLoto.categories = hash;
            formEditorGameOssetianLoto.Show();
            this.Hide();
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
        public Dictionary<string,int> CreateHashOfCats(string[]array)
        {
            Dictionary<string,int> hash = new Dictionary<string,int>();
            for (int i = 0; i < array.Length; i++)
            {
                hash[array[i]]=i;
            }
            return hash;
        }
    }
}
