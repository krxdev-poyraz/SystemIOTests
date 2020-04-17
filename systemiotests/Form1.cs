using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemiotests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Copy = textBox1.Text;
            string Paste = textBox7.Text;
            File.Copy(Copy,Paste);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Delete = textBox2.Text;
            File.Delete(Delete);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Create = textBox3.Text;
            File.Create(Create);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string MoveFile = textBox4.Text;
            string DestFile = textBox8.Text;
            File.Move(MoveFile, DestFile);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Read = textBox5.Text;
            File.ReadAllLines(Read);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = textBox6.Text;
            string[] contents = { textBox9.Text };
            File.WriteAllLines(path,contents);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
