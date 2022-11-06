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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Words.BasicWords refBasicWords = new Words.BasicWords();
        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#b4d8fc");
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#b95726");
            answerone.BackColor = System.Drawing.ColorTranslator.FromHtml("#dbe4ea");
            answerone.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#dadde1");
            answertwo.BackColor = System.Drawing.ColorTranslator.FromHtml("#dbe4ea");
            answertwo.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#dadde1");
            answerthree.BackColor = System.Drawing.ColorTranslator.FromHtml("#dbe4ea");
            answerthree.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#dadde1");
            answerfour.BackColor = System.Drawing.ColorTranslator.FromHtml("#dbe4ea");
            answerfour.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#dadde1");
            QuestionAssigment();
        }

        public void QuestionAssigment()
        {
            refBasicWords.RandomQuestionBuilder();
            word.Text = refBasicWords.SetToWordValue();
            int numberOfElementList = (int)refBasicWords.ReturnOfListDataCount();
            numberOfElement.Text = numberOfElementList.ToString();
            AnswerAssigment();
        }
        private void AnswerAssigment()
        {
            List<int> number = new List<int>() { 1, 2, 3, 4 };
            Random rnd = new Random();
            int sayi1;
            int sayi2;
            int sayi3;
            int sayi4;
            int sayi = rnd.Next(1, 5);
            sayi1 = number[sayi -1];
            number.RemoveAt(sayi - 1);
            sayi = rnd.Next(1, 4);
            sayi2 = number[sayi -1];
            number.RemoveAt(sayi -1);
            sayi = rnd.Next(1,3);
            sayi3 = number[sayi -1];
            number.RemoveAt(sayi -1);
            sayi4 = number[0];
            if (sayi1 == 1)
                answerone.Text = refBasicWords.SetToMeaningValue();
            else if (sayi1 == 2)
                answertwo.Text = refBasicWords.SetToMeaningValue();
            else if (sayi1 == 3)
                answerthree.Text = refBasicWords.SetToMeaningValue();
            else if (sayi1 == 4)
                answerfour.Text = refBasicWords.SetToMeaningValue();
            if (sayi2 == 1)
                answerone.Text = refBasicWords.SetAnsweroneValue();
            else if (sayi2 == 2)
                answertwo.Text = refBasicWords.SetAnsweroneValue();
            else if (sayi2 == 3)
                answerthree.Text = refBasicWords.SetAnsweroneValue();
            else if(sayi2 == 4)
                answerfour.Text = refBasicWords.SetAnsweroneValue();
            if (sayi3 == 1)
                answerone.Text = refBasicWords.SetAnswerotwoValue();
            else if (sayi3 == 2)
                answertwo.Text = refBasicWords.SetAnswerotwoValue();
            else if (sayi3 == 3)
                answerthree.Text = refBasicWords.SetAnswerotwoValue();
            else if (sayi3 == 4)
                answerfour.Text = refBasicWords.SetAnswerotwoValue();
            if (sayi4 == 1)
                answerone.Text = refBasicWords.SetAnswerthreeValue();
            else if (sayi4 == 2)
                answertwo.Text = refBasicWords.SetAnswerthreeValue();
            else if (sayi4 == 3)
                answerthree.Text = refBasicWords.SetAnswerthreeValue();
            else if(sayi4 == 4)
                answerfour.Text = refBasicWords.SetAnswerthreeValue();

        }

        private void ButtonAssigment(string buttonText,Button button)
        {
            if (buttonText == refBasicWords.SetToMeaningValue())
            {
                //dogru ise yeni bir kelime getiricek forma ve kelime sayısı 1 azalıcak! o kelimeyi sözlükten silicek!
                refBasicWords.RemoveAtItem(); //sildim
                //if açıp sorguyu burada yazmam gerek sıfırsa cıkmalı degilse devam etmeli!!!!
                FinishOfWordsAssigment();
            }
            else
            {
                //dogru degil ise yeni kelime getiricek ama kelime sayısı azalmıcak random kelime atıcak ve o kelimeyi silmicek
                QuestionAssigment();
            }
        }
        private void FinishOfWordsAssigment()
        {
            Form3 form3 = new Form3();
            if ((int)refBasicWords.ReturnOfListDataCount() <= 0)
            {
                //formu kapatmalı ve bitirmeli form3 e geçmeli
                MessageBox.Show("Tebrikler bütün kelimeleri bitirdiniz.", "Seviye Geçildi!");
                this.Hide();
                form3.Show();
                form3.levelbasicEnabled();
                //form4 kapandıktan sonra basic kısmına tekrar girilince geri dönüş butonu ve ekranda bir uyarı sistemi kalsın surekli!
            }
            else
            {
                QuestionAssigment(); //yeni kelime getirdi
            }
        }
        private void answerone_Click(object sender, EventArgs e)
        {
            ButtonAssigment(answerone.Text,answerone);
        }

        private void answertwo_Click(object sender, EventArgs e)
        {
            ButtonAssigment(answertwo.Text,answertwo);
        }

        private void answerthree_Click(object sender, EventArgs e)
        {
            ButtonAssigment(answerthree.Text,answerthree);
        }

        private void answerfour_Click(object sender, EventArgs e)
        {
            ButtonAssigment(answerfour.Text,answerfour);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions functions = new Functions();
            functions.AppClose(e);
        }
    }
}

//kelimeler 1 kez bittikten sonra basic butonuna enabled atıyalım ve altına bir adet label atıyıp yeşil yansın bitti şeklinde!
