using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace proji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] files, paths;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                files = opf.SafeFileNames;
                textBox1.Text = opf.FileName;
                for (int x = 0; x < files.Length; x++)
                {
                    listBox1.Items.Add(files[x]);
                }
            }
            
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri(textBox1.Text));
            }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
           /* Process.Start("C:/Users/h0rk1p/Desktop/downloader.exe");*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = listBox1.GetItemText(listBox1.SelectedItem);
            /*vlcControl1.Play(new Uri(item));*/
        }
    }
}
