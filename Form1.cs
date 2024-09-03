using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        Class1 Class1;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            Class1 = new Class1(this);
        }

        int indexer = 2;
        private void button1_Click(object sender, EventArgs e)
        {
            Class1.aabbc = indexer++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1.AddA1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.aabbc = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.aabbd = 1;
        }
    }
}
