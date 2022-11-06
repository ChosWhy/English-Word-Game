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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            wordAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8e8e8");
            wordGame.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8e8e8");
        }
        private void wordGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void wordAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kelime ekleme seçeneği şuanda yapım aşamasında!", "Uyarı!");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions functions = new Functions();
            functions.AppClose(e);
        }
    }
}
