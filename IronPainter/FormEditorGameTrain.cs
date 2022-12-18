﻿using System;
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
            TextBox[] words = {textBoxOssetianWord, textBoxArmenianWord,textBoxGeorgianWord};
            PictureBox[] pictures = { pictureBoxOssetianTrain, pictureBoxArmenianTrain, pictureBoxGeorgianTrain };
            for (int i = 0; i < pictures.Length; i++)
            {
                CreateWagonCard(words[i],pictures[i]);
            }
        }
        public void CreateWagonCard(TextBox output, PictureBox input)
        {
            input.Image = Properties.Resources.FilledWagon;
            Image image = input.Image;
            Graphics gr = Graphics.FromImage(image);
            gr.DrawString(output.Text,
            new System.Drawing.Font("Arial", 16, FontStyle.Regular),
            new SolidBrush(Color.Black), new RectangleF(60, 10, 200, 340),
            new StringFormat(StringFormatFlags.NoWrap));
            input.Image = image;
        }
        private void buttonErasor_Click(object sender, EventArgs e)
        {
            PictureBox[] pictures = {pictureBoxOssetianTrain,pictureBoxArmenianTrain,pictureBoxGeorgianTrain };
            for (int i = 0; i < pictures.Length; i++)
            {
                pictures[i].Image = null;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
