namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TextPole2 = new System.Windows.Forms.ComboBox();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g464_Savosteenko_BaranovDataSet = new WindowsFormsApplication1.g464_Savosteenko_BaranovDataSet();
            this.TextPole7 = new System.Windows.Forms.MaskedTextBox();
            this.TextPole4 = new System.Windows.Forms.MaskedTextBox();
            this.TextPole6 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextPole5 = new System.Windows.Forms.TextBox();
            this.TextPole3 = new System.Windows.Forms.TextBox();
            this.TextPole1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TextPole8 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.view_2TableAdapter = new WindowsFormsApplication1.g464_Savosteenko_BaranovDataSetTableAdapters.View_2TableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g464_Savosteenko_BaranovDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(192, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "64 дней 6 часов и 0 минут до стартамарафона";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(104, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "MARATHON SKILLS 2017";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TextPole2);
            this.groupBox1.Controls.Add(this.TextPole7);
            this.groupBox1.Controls.Add(this.TextPole4);
            this.groupBox1.Controls.Add(this.TextPole6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TextPole5);
            this.groupBox1.Controls.Add(this.TextPole3);
            this.groupBox1.Controls.Add(this.TextPole1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.TextPole8);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 293);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(187, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "/";
            // 
            // TextPole2
            // 
            this.TextPole2.DataSource = this.view2BindingSource;
            this.TextPole2.DisplayMember = "DisplayName";
            this.TextPole2.FormattingEnabled = true;
            this.TextPole2.Location = new System.Drawing.Point(140, 153);
            this.TextPole2.Name = "TextPole2";
            this.TextPole2.Size = new System.Drawing.Size(224, 24);
            this.TextPole2.TabIndex = 2;
            this.TextPole2.ValueMember = "RunnerId";
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "View_2";
            this.view2BindingSource.DataSource = this.g464_Savosteenko_BaranovDataSet;
            // 
            // g464_Savosteenko_BaranovDataSet
            // 
            this.g464_Savosteenko_BaranovDataSet.DataSetName = "g464_Savosteenko_BaranovDataSet";
            this.g464_Savosteenko_BaranovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TextPole7
            // 
            this.TextPole7.Location = new System.Drawing.Point(140, 261);
            this.TextPole7.Mask = "000";
            this.TextPole7.Name = "TextPole7";
            this.TextPole7.Size = new System.Drawing.Size(32, 22);
            this.TextPole7.TabIndex = 7;
            // 
            // TextPole4
            // 
            this.TextPole4.Location = new System.Drawing.Point(140, 207);
            this.TextPole4.Mask = "0000-0000-0000-0000";
            this.TextPole4.Name = "TextPole4";
            this.TextPole4.Size = new System.Drawing.Size(151, 22);
            this.TextPole4.TabIndex = 4;
            // 
            // TextPole6
            // 
            this.TextPole6.Location = new System.Drawing.Point(201, 233);
            this.TextPole6.Name = "TextPole6";
            this.TextPole6.Size = new System.Drawing.Size(60, 22);
            this.TextPole6.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "CVC:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Срок действия:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Номер карты#:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Владелец карты:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Бегун:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ваше имя:";
            // 
            // TextPole5
            // 
            this.TextPole5.Location = new System.Drawing.Point(140, 233);
            this.TextPole5.Name = "TextPole5";
            this.TextPole5.Size = new System.Drawing.Size(44, 22);
            this.TextPole5.TabIndex = 5;
            // 
            // TextPole3
            // 
            this.TextPole3.Location = new System.Drawing.Point(140, 181);
            this.TextPole3.Name = "TextPole3";
            this.TextPole3.Size = new System.Drawing.Size(111, 22);
            this.TextPole3.TabIndex = 3;
            // 
            // TextPole1
            // 
            this.TextPole1.Location = new System.Drawing.Point(140, 130);
            this.TextPole1.Name = "TextPole1";
            this.TextPole1.Size = new System.Drawing.Size(113, 22);
            this.TextPole1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(487, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Отмена";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(381, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Заплатить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TextPole8
            // 
            this.TextPole8.Location = new System.Drawing.Point(439, 227);
            this.TextPole8.MaxLength = 8;
            this.TextPole8.Name = "TextPole8";
            this.TextPole8.Size = new System.Drawing.Size(87, 22);
            this.TextPole8.TabIndex = 9;
            this.TextPole8.Text = "300";
            this.TextPole8.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Location = new System.Drawing.Point(530, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(414, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(441, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "300$";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(396, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Сумма пожертвования";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Фонд Кошек";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(399, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Благотворительность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(51, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Информация о Спонсоре";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(536, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пожалуйста выберите бегуна, которго вы хотели бы спонсировать и сумму, \r\nкоторую " +
    "вы хотели бы спонсировать. Спасибо за вашу поддержку бегунов и их\r\nблаготворител" +
    "ьных учреждений";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Спонсор бегуна";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_2TableAdapter
            // 
            this.view_2TableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(534, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 21);
            this.button6.TabIndex = 29;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(594, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g464_Savosteenko_BaranovDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextPole8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextPole3;
        private System.Windows.Forms.TextBox TextPole1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TextPole5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextPole6;
        private System.Windows.Forms.MaskedTextBox TextPole7;
        private System.Windows.Forms.MaskedTextBox TextPole4;
        private System.Windows.Forms.ComboBox TextPole2;
        private g464_Savosteenko_BaranovDataSet g464_Savosteenko_BaranovDataSet;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private g464_Savosteenko_BaranovDataSetTableAdapters.View_2TableAdapter view_2TableAdapter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button6;
    }
}