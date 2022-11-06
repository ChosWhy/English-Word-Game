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
    public partial class Form3 : Form
    {
        Form2 form2 = new Form2();
        Form4 form4 = new Form4();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#ecdadc");
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#73595c");
            levelBasic.BackColor = System.Drawing.ColorTranslator.FromHtml("#d3c4cb");
            levelMiddle.BackColor = System.Drawing.ColorTranslator.FromHtml("#d3c4cb");
            levelAdvance.BackColor = System.Drawing.ColorTranslator.FromHtml("#d3c4cb");
        }
        public void levelbasicEnabled()
        {
            levelBasic.Enabled = false;
            levelBasic.BackColor = System.Drawing.ColorTranslator.FromHtml("#30c14f");
            note.Visible = true;
        }
        private void levelBasic_Click(object sender, EventArgs e)
        {
                this.Hide();
                form4.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void levelMiddle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şuanlık Diğer leveller aktif değil.\nAnlayışınız için teşekkür ediyoruz.", "Dikkat!");
        }

        private void levelAdvance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şuanlık Diğer leveller aktif değil.\nAnlayışınız için teşekkür ediyoruz.", "Dikkat!");
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions functions = new Functions();
            functions.AppClose(e);
        }
    }
}
