namespace Ingilizce_Kelime_Oyunu
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.levelBasic = new System.Windows.Forms.Button();
            this.levelMiddle = new System.Windows.Forms.Button();
            this.levelAdvance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şimdi çalışmak istediğin seviyeyi seçmelisin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bunun için aşağıdaki bir seviyeyi seçin.";
            // 
            // levelBasic
            // 
            this.levelBasic.FlatAppearance.BorderSize = 0;
            this.levelBasic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.levelBasic.Location = new System.Drawing.Point(39, 376);
            this.levelBasic.Name = "levelBasic";
            this.levelBasic.Size = new System.Drawing.Size(120, 48);
            this.levelBasic.TabIndex = 2;
            this.levelBasic.Text = "Basic";
            this.levelBasic.UseVisualStyleBackColor = true;
            this.levelBasic.Click += new System.EventHandler(this.levelBasic_Click);
            // 
            // levelMiddle
            // 
            this.levelMiddle.FlatAppearance.BorderSize = 0;
            this.levelMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.levelMiddle.Location = new System.Drawing.Point(171, 376);
            this.levelMiddle.Name = "levelMiddle";
            this.levelMiddle.Size = new System.Drawing.Size(120, 48);
            this.levelMiddle.TabIndex = 3;
            this.levelMiddle.Text = "Middle";
            this.levelMiddle.UseVisualStyleBackColor = true;
            this.levelMiddle.Click += new System.EventHandler(this.levelMiddle_Click);
            // 
            // levelAdvance
            // 
            this.levelAdvance.FlatAppearance.BorderSize = 0;
            this.levelAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.levelAdvance.Location = new System.Drawing.Point(303, 376);
            this.levelAdvance.Name = "levelAdvance";
            this.levelAdvance.Size = new System.Drawing.Size(120, 48);
            this.levelAdvance.TabIndex = 4;
            this.levelAdvance.Text = "Advance";
            this.levelAdvance.UseVisualStyleBackColor = true;
            this.levelAdvance.Click += new System.EventHandler(this.levelAdvance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(154, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "WORDAR";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Ingilizce_Kelime_Oyunu.Properties.Resources.btnBack2;
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
            // note
            // 
            this.note.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.note.Location = new System.Drawing.Point(12, 474);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(438, 52);
            this.note.TabIndex = 7;
            this.note.Text = "Not: Geçtiğiniz levelleri tekrar oynamak için Bu sayfaya tekrar giriniz!";
            this.note.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 673);
            this.Controls.Add(this.note);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.levelAdvance);
            this.Controls.Add(this.levelMiddle);
            this.Controls.Add(this.levelBasic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button levelBasic;
        private System.Windows.Forms.Button levelMiddle;
        private System.Windows.Forms.Button levelAdvance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label note;
    }
}