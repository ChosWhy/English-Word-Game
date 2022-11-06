using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingilizce_Kelime_Oyunu
{
    public partial class Form1 : Form
    {
        Words.BasicWords refBasicWords = new Words.BasicWords();
        public object RetRef()
        {
            return refBasicWords;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#eaeaea");
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3da4f2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions functions = new Functions();
            functions.AppClose(e);
        }
    }
}
