using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASCII_Converter.Converter;

namespace ASCII_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image | *.png; *.jpg"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            ConvertFile convert = new ConvertFile(openFileDialog.FileName);
            convert.Start();
        }
    }
}
