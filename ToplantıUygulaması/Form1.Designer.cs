namespace ToplantıUygulaması
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.KAYDET = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ToplantilarListBox = new System.Windows.Forms.ListBox();
            this.BaslikTextBox = new System.Windows.Forms.Label();
            this.BitisDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BaslangicDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.KatilButton = new System.Windows.Forms.Button();
            this.YeniToplantiOlusturButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(180, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 91;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.CausesValidation = false;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(371, 186);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 230);
            this.listView1.TabIndex = 90;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(656, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 89;
            this.listBox1.Visible = false;
            // 
            // KAYDET
            // 
            this.KAYDET.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.KAYDET.Location = new System.Drawing.Point(24, 186);
            this.KAYDET.Name = "KAYDET";
            this.KAYDET.Size = new System.Drawing.Size(145, 23);
            this.KAYDET.TabIndex = 88;
            this.KAYDET.Text = "KAYDET";
            this.KAYDET.UseVisualStyleBackColor = false;
            this.KAYDET.Click += new System.EventHandler(this.KAYDET_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "Bitiş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "Başlangıç:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Ad Soyad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 84;
            // 
            // ToplantilarListBox
            // 
            this.ToplantilarListBox.FormattingEnabled = true;
            this.ToplantilarListBox.ItemHeight = 16;
            this.ToplantilarListBox.Location = new System.Drawing.Point(371, 134);
            this.ToplantilarListBox.Name = "ToplantilarListBox";
            this.ToplantilarListBox.Size = new System.Drawing.Size(387, 36);
            this.ToplantilarListBox.TabIndex = 83;
            // 
            // BaslikTextBox
            // 
            this.BaslikTextBox.AutoSize = true;
            this.BaslikTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BaslikTextBox.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaslikTextBox.Location = new System.Drawing.Point(176, 62);
            this.BaslikTextBox.Name = "BaslikTextBox";
            this.BaslikTextBox.Size = new System.Drawing.Size(416, 21);
            this.BaslikTextBox.TabIndex = 82;
            this.BaslikTextBox.Text = "TOPLANTI UYGULAMASI\r\n";
            // 
            // BitisDateTimePicker
            // 
            this.BitisDateTimePicker.Location = new System.Drawing.Point(125, 284);
            this.BitisDateTimePicker.Name = "BitisDateTimePicker";
            this.BitisDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.BitisDateTimePicker.TabIndex = 81;
            // 
            // BaslangicDateTimePicker
            // 
            this.BaslangicDateTimePicker.Location = new System.Drawing.Point(125, 243);
            this.BaslangicDateTimePicker.Name = "BaslangicDateTimePicker";
            this.BaslangicDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.BaslangicDateTimePicker.TabIndex = 80;
            // 
            // KatilButton
            // 
            this.KatilButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.KatilButton.Location = new System.Drawing.Point(180, 147);
            this.KatilButton.Name = "KatilButton";
            this.KatilButton.Size = new System.Drawing.Size(145, 23);
            this.KatilButton.TabIndex = 79;
            this.KatilButton.Text = "Katıl";
            this.KatilButton.UseVisualStyleBackColor = false;
            this.KatilButton.Click += new System.EventHandler(this.KatilButton_Click);
            // 
            // YeniToplantiOlusturButton
            // 
            this.YeniToplantiOlusturButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.YeniToplantiOlusturButton.Location = new System.Drawing.Point(24, 147);
            this.YeniToplantiOlusturButton.Name = "YeniToplantiOlusturButton";
            this.YeniToplantiOlusturButton.Size = new System.Drawing.Size(145, 23);
            this.YeniToplantiOlusturButton.TabIndex = 78;
            this.YeniToplantiOlusturButton.Text = "Kod Oluştur";
            this.YeniToplantiOlusturButton.UseVisualStyleBackColor = false;
            this.YeniToplantiOlusturButton.Click += new System.EventHandler(this.YeniToplantiOlusturButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(42, 400);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 16);
            this.linkLabel1.TabIndex = 92;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "TAKVİMİ GÖRMEK İÇİN TIKLA";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.KAYDET);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ToplantilarListBox);
            this.Controls.Add(this.BaslikTextBox);
            this.Controls.Add(this.BitisDateTimePicker);
            this.Controls.Add(this.BaslangicDateTimePicker);
            this.Controls.Add(this.KatilButton);
            this.Controls.Add(this.YeniToplantiOlusturButton);
            this.Name = "Form1";
            this.Text = "toplantı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button KAYDET;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox ToplantilarListBox;
        private System.Windows.Forms.Label BaslikTextBox;
        private System.Windows.Forms.DateTimePicker BitisDateTimePicker;
        private System.Windows.Forms.DateTimePicker BaslangicDateTimePicker;
        private System.Windows.Forms.Button KatilButton;
        private System.Windows.Forms.Button YeniToplantiOlusturButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

