namespace Ingilizce_Kelime_Oyunu
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.word = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answerone = new System.Windows.Forms.Button();
            this.answertwo = new System.Windows.Forms.Button();
            this.answerthree = new System.Windows.Forms.Button();
            this.answerfour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.numberOfElement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.Location = new System.Drawing.Point(12, 91);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(438, 44);
            this.word.TabIndex = 0;
            this.word.Text = "Word";
            this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(165, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Türkçesi nedir?";
            // 
            // answerone
            // 
            this.answerone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerone.FlatAppearance.BorderSize = 0;
            this.answerone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerone.Location = new System.Drawing.Point(40, 262);
            this.answerone.MaximumSize = new System.Drawing.Size(170, 50);
            this.answerone.Name = "answerone";
            this.answerone.Size = new System.Drawing.Size(170, 50);
            this.answerone.TabIndex = 2;
            this.answerone.Text = "Cevap Bir";
            this.answerone.UseVisualStyleBackColor = true;
            this.answerone.Click += new System.EventHandler(this.answerone_Click);
            // 
            // answertwo
            // 
            this.answertwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answertwo.FlatAppearance.BorderSize = 0;
            this.answertwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answertwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answertwo.Location = new System.Drawing.Point(250, 262);
            this.answertwo.Name = "answertwo";
            this.answertwo.Size = new System.Drawing.Size(170, 50);
            this.answertwo.TabIndex = 3;
            this.answertwo.Text = "Cevap İki";
            this.answertwo.UseVisualStyleBackColor = true;
            this.answertwo.Click += new System.EventHandler(this.answertwo_Click);
            // 
            // answerthree
            // 
            this.answerthree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerthree.FlatAppearance.BorderSize = 0;
            this.answerthree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerthree.Location = new System.Drawing.Point(40, 370);
            this.answerthree.Name = "answerthree";
            this.answerthree.Size = new System.Drawing.Size(170, 50);
            this.answerthree.TabIndex = 4;
            this.answerthree.Text = "Cevap Üç";
            this.answerthree.UseVisualStyleBackColor = true;
            this.answerthree.Click += new System.EventHandler(this.answerthree_Click);
            // 
            // answerfour
            // 
            this.answerfour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerfour.FlatAppearance.BorderSize = 0;
            this.answerfour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerfour.Location = new System.Drawing.Point(250, 370);
            this.answerfour.Name = "answerfour";
            this.answerfour.Size = new System.Drawing.Size(170, 50);
            this.answerfour.TabIndex = 5;
            this.answerfour.Text = "Cevap Dört";
            this.answerfour.UseVisualStyleBackColor = true;
            this.answerfour.Click += new System.EventHandler(this.answerfour_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Geriye kalan soru sayısı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Ingilizce_Kelime_Oyunu.Properties.Resources.btnBack1;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numberOfElement
            // 
            this.numberOfElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberOfElement.Location = new System.Drawing.Point(9, 514);
            this.numberOfElement.Name = "numberOfElement";
            this.numberOfElement.Size = new System.Drawing.Size(437, 23);
            this.numberOfElement.TabIndex = 9;
            this.numberOfElement.Text = "Adet";
            this.numberOfElement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 673);
            this.Controls.Add(this.numberOfElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.answerfour);
            this.Controls.Add(this.answerthree);
            this.Controls.Add(this.answertwo);
            this.Controls.Add(this.answerone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.word);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button answerone;
        private System.Windows.Forms.Button answertwo;
        private System.Windows.Forms.Button answerthree;
        private System.Windows.Forms.Button answerfour;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOfElement;
    }
}