namespace WindowsFormsApp5
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.kayitListeleButton = new System.Windows.Forms.Button();
            this.kayitEkleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.kayitSilButton = new System.Windows.Forms.Button();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kayitGuncelleButton = new System.Windows.Forms.Button();
            this.kayitAraButton = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saatLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.disaAktarButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(12, 347);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1175, 293);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // kayitListeleButton
            // 
            this.kayitListeleButton.Location = new System.Drawing.Point(12, 12);
            this.kayitListeleButton.Name = "kayitListeleButton";
            this.kayitListeleButton.Size = new System.Drawing.Size(174, 23);
            this.kayitListeleButton.TabIndex = 1;
            this.kayitListeleButton.Text = "Kayitlari Listele";
            this.kayitListeleButton.UseVisualStyleBackColor = true;
            this.kayitListeleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayitEkleButton
            // 
            this.kayitEkleButton.Location = new System.Drawing.Point(12, 41);
            this.kayitEkleButton.Name = "kayitEkleButton";
            this.kayitEkleButton.Size = new System.Drawing.Size(174, 23);
            this.kayitEkleButton.TabIndex = 2;
            this.kayitEkleButton.Text = "Kayit Ekle";
            this.kayitEkleButton.UseVisualStyleBackColor = true;
            this.kayitEkleButton.Click += new System.EventHandler(this.kayitEkleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tc:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "OdaNo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(662, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "YatisTarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "TaburcuTarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "TelefonNo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(685, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ucret:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(732, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(732, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(732, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(732, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(732, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(732, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(732, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(414, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(732, 176);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(414, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // kayitSilButton
            // 
            this.kayitSilButton.Location = new System.Drawing.Point(13, 71);
            this.kayitSilButton.Name = "kayitSilButton";
            this.kayitSilButton.Size = new System.Drawing.Size(173, 23);
            this.kayitSilButton.TabIndex = 19;
            this.kayitSilButton.Text = "Kayit Sil";
            this.kayitSilButton.UseVisualStyleBackColor = true;
            this.kayitSilButton.Click += new System.EventHandler(this.kayitSilButton_Click);
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(732, 15);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(100, 20);
            this.idtextbox.TabIndex = 20;
            this.idtextbox.TextChanged += new System.EventHandler(this.idtextbox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(703, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "id:";
            // 
            // kayitGuncelleButton
            // 
            this.kayitGuncelleButton.Location = new System.Drawing.Point(12, 100);
            this.kayitGuncelleButton.Name = "kayitGuncelleButton";
            this.kayitGuncelleButton.Size = new System.Drawing.Size(174, 23);
            this.kayitGuncelleButton.TabIndex = 22;
            this.kayitGuncelleButton.Text = "Kayit Guncelle";
            this.kayitGuncelleButton.UseVisualStyleBackColor = true;
            this.kayitGuncelleButton.Click += new System.EventHandler(this.kayitGuncelleButton_Click);
            // 
            // kayitAraButton
            // 
            this.kayitAraButton.Location = new System.Drawing.Point(238, 13);
            this.kayitAraButton.Name = "kayitAraButton";
            this.kayitAraButton.Size = new System.Drawing.Size(174, 23);
            this.kayitAraButton.TabIndex = 23;
            this.kayitAraButton.Text = "Kayit Ara";
            this.kayitAraButton.UseVisualStyleBackColor = true;
            this.kayitAraButton.Click += new System.EventHandler(this.kayitAraButton_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(238, 43);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(174, 20);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox7.Font = new System.Drawing.Font("Zilla Slab", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(13, 245);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(331, 52);
            this.textBox7.TabIndex = 25;
            this.textBox7.Text = "Hastanemiz, Sağlıklı Günler Diler...";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.move);
            // 
            // saatLabel
            // 
            this.saatLabel.AutoSize = true;
            this.saatLabel.BackColor = System.Drawing.Color.MintCream;
            this.saatLabel.Font = new System.Drawing.Font("Javanese Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saatLabel.ForeColor = System.Drawing.Color.Red;
            this.saatLabel.Location = new System.Drawing.Point(953, 231);
            this.saatLabel.Name = "saatLabel";
            this.saatLabel.Size = new System.Drawing.Size(0, 80);
            this.saatLabel.TabIndex = 26;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.time);
            // 
            // disaAktarButon
            // 
            this.disaAktarButon.Location = new System.Drawing.Point(1071, 293);
            this.disaAktarButon.Name = "disaAktarButon";
            this.disaAktarButon.Size = new System.Drawing.Size(75, 23);
            this.disaAktarButon.TabIndex = 27;
            this.disaAktarButon.Text = "Dışa Aktar";
            this.disaAktarButon.UseVisualStyleBackColor = true;
            this.disaAktarButon.Click += new System.EventHandler(this.disaAktarButon_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 672);
            this.Controls.Add(this.disaAktarButon);
            this.Controls.Add(this.saatLabel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.kayitAraButton);
            this.Controls.Add(this.kayitGuncelleButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.kayitSilButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayitEkleButton);
            this.Controls.Add(this.kayitListeleButton);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "Hasta Kayit Formu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button kayitListeleButton;
        private System.Windows.Forms.Button kayitEkleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button kayitSilButton;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button kayitGuncelleButton;
        private System.Windows.Forms.Button kayitAraButton;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label saatLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button disaAktarButon;
    }
}