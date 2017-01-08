namespace MovieMakerGrap
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxWlmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhat2Store = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSelectFolder = new System.Windows.Forms.Button();
            this.bSelectWlmp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bReset = new System.Windows.Forms.Button();
            this.tAudio = new System.Windows.Forms.TextBox();
            this.bGo = new System.Windows.Forms.Button();
            this.bAnalyse = new System.Windows.Forms.Button();
            this.tPicture = new System.Windows.Forms.TextBox();
            this.tMovie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWlmp
            // 
            this.textBoxWlmp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWlmp.Location = new System.Drawing.Point(156, 21);
            this.textBoxWlmp.Name = "textBoxWlmp";
            this.textBoxWlmp.Size = new System.Drawing.Size(213, 22);
            this.textBoxWlmp.TabIndex = 0;
            this.textBoxWlmp.Text = "Select a wlmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Maker File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path to Store Media:";
            // 
            // textBoxPhat2Store
            // 
            this.textBoxPhat2Store.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhat2Store.Location = new System.Drawing.Point(156, 49);
            this.textBoxPhat2Store.Name = "textBoxPhat2Store";
            this.textBoxPhat2Store.Size = new System.Drawing.Size(213, 22);
            this.textBoxPhat2Store.TabIndex = 3;
            this.textBoxPhat2Store.Text = "Path to Store your Media";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bSelectFolder);
            this.groupBox1.Controls.Add(this.bSelectWlmp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxWlmp);
            this.groupBox1.Controls.Add(this.textBoxPhat2Store);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files and Path";
            // 
            // bSelectFolder
            // 
            this.bSelectFolder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSelectFolder.Location = new System.Drawing.Point(385, 49);
            this.bSelectFolder.Name = "bSelectFolder";
            this.bSelectFolder.Size = new System.Drawing.Size(71, 23);
            this.bSelectFolder.TabIndex = 5;
            this.bSelectFolder.Text = "Select";
            this.bSelectFolder.UseVisualStyleBackColor = true;
            // 
            // bSelectWlmp
            // 
            this.bSelectWlmp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSelectWlmp.Location = new System.Drawing.Point(385, 20);
            this.bSelectWlmp.Name = "bSelectWlmp";
            this.bSelectWlmp.Size = new System.Drawing.Size(71, 23);
            this.bSelectWlmp.TabIndex = 4;
            this.bSelectWlmp.Text = "Open";
            this.bSelectWlmp.UseVisualStyleBackColor = true;
            this.bSelectWlmp.Click += new System.EventHandler(this.bSelectWlmp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bReset);
            this.groupBox2.Controls.Add(this.tAudio);
            this.groupBox2.Controls.Add(this.bGo);
            this.groupBox2.Controls.Add(this.bAnalyse);
            this.groupBox2.Controls.Add(this.tPicture);
            this.groupBox2.Controls.Add(this.tMovie);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Statistic";
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(385, 71);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(71, 23);
            this.bReset.TabIndex = 8;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            // 
            // tAudio
            // 
            this.tAudio.Location = new System.Drawing.Point(87, 74);
            this.tAudio.Name = "tAudio";
            this.tAudio.Size = new System.Drawing.Size(78, 20);
            this.tAudio.TabIndex = 5;
            // 
            // bGo
            // 
            this.bGo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGo.Location = new System.Drawing.Point(385, 42);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(71, 23);
            this.bGo.TabIndex = 7;
            this.bGo.Text = "Go";
            this.bGo.UseVisualStyleBackColor = true;
            // 
            // bAnalyse
            // 
            this.bAnalyse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnalyse.Location = new System.Drawing.Point(385, 16);
            this.bAnalyse.Name = "bAnalyse";
            this.bAnalyse.Size = new System.Drawing.Size(71, 23);
            this.bAnalyse.TabIndex = 6;
            this.bAnalyse.Text = "Check";
            this.bAnalyse.UseVisualStyleBackColor = true;
            // 
            // tPicture
            // 
            this.tPicture.Location = new System.Drawing.Point(87, 45);
            this.tPicture.Name = "tPicture";
            this.tPicture.Size = new System.Drawing.Size(78, 20);
            this.tPicture.TabIndex = 4;
            // 
            // tMovie
            // 
            this.tMovie.Location = new System.Drawing.Point(87, 19);
            this.tMovie.Name = "tMovie";
            this.tMovie.Size = new System.Drawing.Size(78, 20);
            this.tMovie.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Audio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Picture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Movies:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "Movie Maker Grap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWlmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPhat2Store;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bSelectFolder;
        private System.Windows.Forms.Button bSelectWlmp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.TextBox tAudio;
        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.Button bAnalyse;
        private System.Windows.Forms.TextBox tPicture;
        private System.Windows.Forms.TextBox tMovie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

