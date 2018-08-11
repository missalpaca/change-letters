using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetrasMoxxas
{
    public partial class Form1 : Form
    {
        public string texto;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = letra.Text.Replace("h", "").Replace("H", "").Replace("y", "i").Replace("a", "A").Replace("e", "3").Replace("v", "b").Replace("i", "iI").Replace("o", "0").Replace("b", "v").Replace("s", "z").Replace("qu", "k").Replace("z", "zh".Replace("r", "R"));
            txt2.Text = System.Convert.ToString(texto);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acercade acercade = new acercade();
            acercade.Show();
        }

        private void texto_Click(object sender, EventArgs e)
        {
            
        }
    }
}
