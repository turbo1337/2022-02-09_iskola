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

namespace _2022_02_09_iskola
{
    public partial class Form1 : Form
    {
        List<Tanuló> Tanulók = new List<Tanuló>();
        BindingSource bs = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnkilépés_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbetöltés_Click(object sender, EventArgs e)
        {
            foreach (var sor in File.ReadAllLines("nevek.txt")) 
            {
                Tanulók.Add(new Tanuló(sor));
            }
            bs = new BindingSource();
            bs.DataSource = Tanulók;
            listBox1.DataSource = bs;
        }
    }
}
