namespace HomeWork_1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.hackerText = new System.Windows.Forms.TextBox();
            this.hacker = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serverText = new System.Windows.Forms.TextBox();
            this.probText = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.server = new System.Windows.Forms.Label();
            this.probability = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.averageBox = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // hackerText
            // 
            this.hackerText.Location = new System.Drawing.Point(16, 53);
            this.hackerText.Name = "hackerText";
            this.hackerText.Size = new System.Drawing.Size(163, 20);
            this.hackerText.TabIndex = 0;
            // 
            // hacker
            // 
            this.hacker.AutoSize = true;
            this.hacker.Location = new System.Drawing.Point(13, 37);
            this.hacker.Name = "hacker";
            this.hacker.Size = new System.Drawing.Size(83, 13);
            this.hacker.TabIndex = 1;
            this.hacker.Text = "hackers number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 283);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // serverText
            // 
            this.serverText.Location = new System.Drawing.Point(185, 53);
            this.serverText.Name = "serverText";
            this.serverText.Size = new System.Drawing.Size(179, 20);
            this.serverText.TabIndex = 3;
            // 
            // probText
            // 
            this.probText.Location = new System.Drawing.Point(370, 53);
            this.probText.Name = "probText";
            this.probText.Size = new System.Drawing.Size(194, 20);
            this.probText.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(492, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(483, 283);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // server
            // 
            this.server.AutoSize = true;
            this.server.Location = new System.Drawing.Point(185, 37);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(79, 13);
            this.server.TabIndex = 6;
            this.server.Text = "servers number";
            // 
            // probability
            // 
            this.probability.AutoSize = true;
            this.probability.Location = new System.Drawing.Point(370, 37);
            this.probability.Name = "probability";
            this.probability.Size = new System.Drawing.Size(92, 13);
            this.probability.TabIndex = 7;
            this.probability.Text = "probability number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // averageBox
            // 
            this.averageBox.Location = new System.Drawing.Point(492, 371);
            this.averageBox.Name = "averageBox";
            this.averageBox.ReadOnly = true;
            this.averageBox.Size = new System.Drawing.Size(110, 20);
            this.averageBox.TabIndex = 9;
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Location = new System.Drawing.Point(336, 374);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(150, 13);
            this.average.TabIndex = 10;
            this.average.Text = "Average of successful attacks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 432);
            this.Controls.Add(this.average);
            this.Controls.Add(this.averageBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.probability);
            this.Controls.Add(this.server);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.probText);
            this.Controls.Add(this.serverText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hacker);
            this.Controls.Add(this.hackerText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hackerText;
        private System.Windows.Forms.Label hacker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox serverText;
        private System.Windows.Forms.TextBox probText;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label server;
        private System.Windows.Forms.Label probability;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox averageBox;
        private System.Windows.Forms.Label average;
    }
}

