namespace WindowsFormsApplication20
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Stat_B = new System.Windows.Forms.Button();
            this.Stat_TB = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Count_NUD = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.Input_NUD = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Manual_B = new System.Windows.Forms.Button();
            this.Manual_RB = new System.Windows.Forms.RadioButton();
            this.Auto_RB = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CommonProv_LB = new System.Windows.Forms.ListBox();
            this.VipProv_LB = new System.Windows.Forms.ListBox();
            this.ProvCar_TB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CommonBal_LB = new System.Windows.Forms.ListBox();
            this.VipBal_LB = new System.Windows.Forms.ListBox();
            this.BalCar_TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CommonZam_LB = new System.Windows.Forms.ListBox();
            this.VipZam_LB = new System.Windows.Forms.ListBox();
            this.ZamCar_TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CommonWash_LB = new System.Windows.Forms.ListBox();
            this.VipWash_LB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WashCar_TB = new System.Windows.Forms.TextBox();
            this.FactCar_TB = new System.Windows.Forms.TextBox();
            this.Timer_T = new System.Windows.Forms.Timer(this.components);
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NUD)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Stat_B);
            this.groupBox7.Controls.Add(this.Stat_TB);
            this.groupBox7.Location = new System.Drawing.Point(1065, 271);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(302, 424);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Отчет";
            // 
            // Stat_B
            // 
            this.Stat_B.Enabled = false;
            this.Stat_B.Location = new System.Drawing.Point(24, 36);
            this.Stat_B.Name = "Stat_B";
            this.Stat_B.Size = new System.Drawing.Size(75, 23);
            this.Stat_B.TabIndex = 1;
            this.Stat_B.Text = "Отчет";
            this.Stat_B.UseVisualStyleBackColor = true;
            this.Stat_B.Click += new System.EventHandler(this.Stat_B_Click);
            // 
            // Stat_TB
            // 
            this.Stat_TB.Location = new System.Drawing.Point(9, 65);
            this.Stat_TB.Multiline = true;
            this.Stat_TB.Name = "Stat_TB";
            this.Stat_TB.ReadOnly = true;
            this.Stat_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Stat_TB.Size = new System.Drawing.Size(287, 294);
            this.Stat_TB.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Count_NUD);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.Input_NUD);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(1123, 142);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Новые автомобили";
            // 
            // Count_NUD
            // 
            this.Count_NUD.Location = new System.Drawing.Point(116, 61);
            this.Count_NUD.Name = "Count_NUD";
            this.Count_NUD.Size = new System.Drawing.Size(34, 20);
            this.Count_NUD.TabIndex = 3;
            this.Count_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Количество от 1 до";
            // 
            // Input_NUD
            // 
            this.Input_NUD.Location = new System.Drawing.Point(161, 30);
            this.Input_NUD.Name = "Input_NUD";
            this.Input_NUD.Size = new System.Drawing.Size(34, 20);
            this.Input_NUD.TabIndex = 1;
            this.Input_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Input_NUD.ValueChanged += new System.EventHandler(this.Input_NUD_ValueChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Вероятность появление 1 из";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Manual_B);
            this.groupBox5.Controls.Add(this.Manual_RB);
            this.groupBox5.Controls.Add(this.Auto_RB);
            this.groupBox5.Location = new System.Drawing.Point(1123, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 111);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление";
            // 
            // Manual_B
            // 
            this.Manual_B.Enabled = false;
            this.Manual_B.Location = new System.Drawing.Point(90, 82);
            this.Manual_B.Name = "Manual_B";
            this.Manual_B.Size = new System.Drawing.Size(105, 23);
            this.Manual_B.TabIndex = 2;
            this.Manual_B.Text = "Выполнить шаг";
            this.Manual_B.UseVisualStyleBackColor = true;
            this.Manual_B.Click += new System.EventHandler(this.Manual_B_Click_1);
            // 
            // Manual_RB
            // 
            this.Manual_RB.AutoSize = true;
            this.Manual_RB.Location = new System.Drawing.Point(6, 62);
            this.Manual_RB.Name = "Manual_RB";
            this.Manual_RB.Size = new System.Drawing.Size(67, 17);
            this.Manual_RB.TabIndex = 1;
            this.Manual_RB.TabStop = true;
            this.Manual_RB.Text = "Вручную";
            this.Manual_RB.UseVisualStyleBackColor = true;
            this.Manual_RB.CheckedChanged += new System.EventHandler(this.SetMod);
            // 
            // Auto_RB
            // 
            this.Auto_RB.AutoSize = true;
            this.Auto_RB.Location = new System.Drawing.Point(6, 28);
            this.Auto_RB.Name = "Auto_RB";
            this.Auto_RB.Size = new System.Drawing.Size(103, 17);
            this.Auto_RB.TabIndex = 0;
            this.Auto_RB.TabStop = true;
            this.Auto_RB.Text = "Автоматически";
            this.Auto_RB.UseVisualStyleBackColor = true;
            this.Auto_RB.CheckedChanged += new System.EventHandler(this.SetMod);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.CommonProv_LB);
            this.groupBox4.Controls.Add(this.VipProv_LB);
            this.groupBox4.Controls.Add(this.ProvCar_TB);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(781, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 470);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Обычная очередь";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Обычная очередь";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Очередь по графику";
            // 
            // CommonProv_LB
            // 
            this.CommonProv_LB.FormattingEnabled = true;
            this.CommonProv_LB.Location = new System.Drawing.Point(6, 293);
            this.CommonProv_LB.Name = "CommonProv_LB";
            this.CommonProv_LB.Size = new System.Drawing.Size(223, 160);
            this.CommonProv_LB.TabIndex = 13;
            // 
            // VipProv_LB
            // 
            this.VipProv_LB.FormattingEnabled = true;
            this.VipProv_LB.Location = new System.Drawing.Point(6, 101);
            this.VipProv_LB.Name = "VipProv_LB";
            this.VipProv_LB.Size = new System.Drawing.Size(223, 147);
            this.VipProv_LB.TabIndex = 12;
            // 
            // ProvCar_TB
            // 
            this.ProvCar_TB.Location = new System.Drawing.Point(21, 44);
            this.ProvCar_TB.Name = "ProvCar_TB";
            this.ProvCar_TB.ReadOnly = true;
            this.ProvCar_TB.Size = new System.Drawing.Size(195, 20);
            this.ProvCar_TB.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Операция \"Проверка электроники\"";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.CommonBal_LB);
            this.groupBox3.Controls.Add(this.VipBal_LB);
            this.groupBox3.Controls.Add(this.BalCar_TB);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(519, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 470);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обычная очередь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Обычная очередь";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Очередь по графику";
            // 
            // CommonBal_LB
            // 
            this.CommonBal_LB.FormattingEnabled = true;
            this.CommonBal_LB.Location = new System.Drawing.Point(6, 293);
            this.CommonBal_LB.Name = "CommonBal_LB";
            this.CommonBal_LB.Size = new System.Drawing.Size(223, 160);
            this.CommonBal_LB.TabIndex = 13;
            // 
            // VipBal_LB
            // 
            this.VipBal_LB.FormattingEnabled = true;
            this.VipBal_LB.Location = new System.Drawing.Point(6, 101);
            this.VipBal_LB.Name = "VipBal_LB";
            this.VipBal_LB.Size = new System.Drawing.Size(223, 147);
            this.VipBal_LB.TabIndex = 12;
            // 
            // BalCar_TB
            // 
            this.BalCar_TB.Location = new System.Drawing.Point(21, 44);
            this.BalCar_TB.Name = "BalCar_TB";
            this.BalCar_TB.ReadOnly = true;
            this.BalCar_TB.Size = new System.Drawing.Size(195, 20);
            this.BalCar_TB.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Операция \"Балансировка  колес\"";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.CommonZam_LB);
            this.groupBox2.Controls.Add(this.VipZam_LB);
            this.groupBox2.Controls.Add(this.ZamCar_TB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(268, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 470);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обычная очередь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Обычная очередь";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Очередь по графику";
            // 
            // CommonZam_LB
            // 
            this.CommonZam_LB.FormattingEnabled = true;
            this.CommonZam_LB.Location = new System.Drawing.Point(6, 293);
            this.CommonZam_LB.Name = "CommonZam_LB";
            this.CommonZam_LB.Size = new System.Drawing.Size(223, 160);
            this.CommonZam_LB.TabIndex = 13;
            // 
            // VipZam_LB
            // 
            this.VipZam_LB.FormattingEnabled = true;
            this.VipZam_LB.Location = new System.Drawing.Point(6, 101);
            this.VipZam_LB.Name = "VipZam_LB";
            this.VipZam_LB.Size = new System.Drawing.Size(223, 147);
            this.VipZam_LB.TabIndex = 12;
            // 
            // ZamCar_TB
            // 
            this.ZamCar_TB.Location = new System.Drawing.Point(21, 44);
            this.ZamCar_TB.Name = "ZamCar_TB";
            this.ZamCar_TB.ReadOnly = true;
            this.ZamCar_TB.Size = new System.Drawing.Size(195, 20);
            this.ZamCar_TB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Операция \"Замена жидкостей\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CommonWash_LB);
            this.groupBox1.Controls.Add(this.VipWash_LB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WashCar_TB);
            this.groupBox1.Location = new System.Drawing.Point(23, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 470);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Очередь по графику";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Обычная очередь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Очередь по графику";
            // 
            // CommonWash_LB
            // 
            this.CommonWash_LB.FormattingEnabled = true;
            this.CommonWash_LB.Location = new System.Drawing.Point(15, 293);
            this.CommonWash_LB.Name = "CommonWash_LB";
            this.CommonWash_LB.Size = new System.Drawing.Size(195, 160);
            this.CommonWash_LB.TabIndex = 9;
            // 
            // VipWash_LB
            // 
            this.VipWash_LB.FormattingEnabled = true;
            this.VipWash_LB.Location = new System.Drawing.Point(15, 101);
            this.VipWash_LB.Name = "VipWash_LB";
            this.VipWash_LB.Size = new System.Drawing.Size(195, 147);
            this.VipWash_LB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Операция \"Мойка\"";
            // 
            // WashCar_TB
            // 
            this.WashCar_TB.Location = new System.Drawing.Point(6, 44);
            this.WashCar_TB.Name = "WashCar_TB";
            this.WashCar_TB.ReadOnly = true;
            this.WashCar_TB.Size = new System.Drawing.Size(195, 20);
            this.WashCar_TB.TabIndex = 0;
            // 
            // FactCar_TB
            // 
            this.FactCar_TB.ForeColor = System.Drawing.Color.Black;
            this.FactCar_TB.Location = new System.Drawing.Point(12, 490);
            this.FactCar_TB.Multiline = true;
            this.FactCar_TB.Name = "FactCar_TB";
            this.FactCar_TB.ReadOnly = true;
            this.FactCar_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FactCar_TB.Size = new System.Drawing.Size(1037, 129);
            this.FactCar_TB.TabIndex = 21;
            // 
            // Timer_T
            // 
            this.Timer_T.Tick += new System.EventHandler(this.Timer_T_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 633);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FactCar_TB);
            this.Name = "Form1";
            this.Text = "Автосервис";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Count_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NUD)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Stat_B;
        private System.Windows.Forms.TextBox Stat_TB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown Count_NUD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown Input_NUD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Manual_B;
        private System.Windows.Forms.RadioButton Manual_RB;
        private System.Windows.Forms.RadioButton Auto_RB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox CommonProv_LB;
        private System.Windows.Forms.ListBox VipProv_LB;
        private System.Windows.Forms.TextBox ProvCar_TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox CommonBal_LB;
        private System.Windows.Forms.ListBox VipBal_LB;
        private System.Windows.Forms.TextBox BalCar_TB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox CommonZam_LB;
        private System.Windows.Forms.ListBox VipZam_LB;
        private System.Windows.Forms.TextBox ZamCar_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox CommonWash_LB;
        private System.Windows.Forms.ListBox VipWash_LB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WashCar_TB;
        private System.Windows.Forms.TextBox FactCar_TB;
        private System.Windows.Forms.Timer Timer_T;

    }
}

