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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.variaceLabel = new System.Windows.Forms.Label();
            this.varianceBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // hackerText
            // 
            this.hackerText.Location = new System.Drawing.Point(35, 51);
            this.hackerText.Name = "hackerText";
            this.hackerText.Size = new System.Drawing.Size(163, 20);
            this.hackerText.TabIndex = 0;
            // 
            // hacker
            // 
            this.hacker.AutoSize = true;
            this.hacker.Location = new System.Drawing.Point(32, 35);
            this.hacker.Name = "hacker";
            this.hacker.Size = new System.Drawing.Size(83, 13);
            this.hacker.TabIndex = 1;
            this.hacker.Text = "hackers number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 281);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // serverText
            // 
            this.serverText.Location = new System.Drawing.Point(204, 51);
            this.serverText.Name = "serverText";
            this.serverText.Size = new System.Drawing.Size(179, 20);
            this.serverText.TabIndex = 3;
            // 
            // probText
            // 
            this.probText.Location = new System.Drawing.Point(389, 51);
            this.probText.Name = "probText";
            this.probText.Size = new System.Drawing.Size(194, 20);
            this.probText.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(723, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(377, 281);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // server
            // 
            this.server.AutoSize = true;
            this.server.Location = new System.Drawing.Point(204, 35);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(79, 13);
            this.server.TabIndex = 6;
            this.server.Text = "servers number";
            // 
            // probability
            // 
            this.probability.AutoSize = true;
            this.probability.Location = new System.Drawing.Point(389, 35);
            this.probability.Name = "probability";
            this.probability.Size = new System.Drawing.Size(92, 13);
            this.probability.TabIndex = 7;
            this.probability.Text = "probability number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // averageBox
            // 
            this.averageBox.Location = new System.Drawing.Point(188, 714);
            this.averageBox.Name = "averageBox";
            this.averageBox.ReadOnly = true;
            this.averageBox.Size = new System.Drawing.Size(118, 20);
            this.averageBox.TabIndex = 9;
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Location = new System.Drawing.Point(32, 717);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(150, 13);
            this.average.TabIndex = 10;
            this.average.Text = "Average of successful attacks";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(35, 391);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(529, 305);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(571, 391);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(529, 305);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(590, 50);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 20);
            this.time.TabIndex = 13;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(589, 35);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(61, 13);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "Time stamp";
            // 
            // variaceLabel
            // 
            this.variaceLabel.AutoSize = true;
            this.variaceLabel.Location = new System.Drawing.Point(342, 720);
            this.variaceLabel.Name = "variaceLabel";
            this.variaceLabel.Size = new System.Drawing.Size(49, 13);
            this.variaceLabel.TabIndex = 15;
            this.variaceLabel.Text = "Variance";
            // 
            // variance
            // 
            this.varianceBox.Location = new System.Drawing.Point(397, 714);
            this.varianceBox.Name = "variance";
            this.varianceBox.ReadOnly = true;
            this.varianceBox.Size = new System.Drawing.Size(100, 20);
            this.varianceBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 778);
            this.Controls.Add(this.varianceBox);
            this.Controls.Add(this.variaceLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.time);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label variaceLabel;
        private System.Windows.Forms.TextBox varianceBox;
    }
}

