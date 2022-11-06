namespace Ingilizce_Kelime_Oyunu
{
    partial class Form2
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
            this.wordGame = new System.Windows.Forms.Button();
            this.wordAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordGame
            // 
            this.wordGame.FlatAppearance.BorderSize = 0;
            this.wordGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordGame.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordGame.Location = new System.Drawing.Point(448, 207);
            this.wordGame.Name = "wordGame";
            this.wordGame.Size = new System.Drawing.Size(164, 50);
            this.wordGame.TabIndex = 0;
            this.wordGame.Text = "Kelime Oyunu";
            this.wordGame.UseVisualStyleBackColor = true;
            this.wordGame.Click += new System.EventHandler(this.wordGame_Click);
            // 
            // wordAdd
            // 
            this.wordAdd.FlatAppearance.BorderSize = 0;
            this.wordAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordAdd.Location = new System.Drawing.Point(448, 471);
            this.wordAdd.Name = "wordAdd";
            this.wordAdd.Size = new System.Drawing.Size(164, 50);
            this.wordAdd.TabIndex = 1;
            this.wordAdd.Text = "Kelime Ekle";
            this.wordAdd.UseVisualStyleBackColor = true;
            this.wordAdd.Click += new System.EventHandler(this.wordAdd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ingilizce_Kelime_Oyunu.Properties.Resources.Words;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.wordAdd);
            this.Controls.Add(this.wordGame);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wordGame;
        private System.Windows.Forms.Button wordAdd;
    }
}