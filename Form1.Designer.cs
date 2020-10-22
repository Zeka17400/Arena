namespace AvtoRPG
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_HP = new System.Windows.Forms.TextBox();
            this.textBox_GOLD = new System.Windows.Forms.TextBox();
            this.textBox_EXP = new System.Windows.Forms.TextBox();
            this.textBox_DMG = new System.Windows.Forms.TextBox();
            this.button_LOCATION = new System.Windows.Forms.Button();
            this.button_SHOP = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.autorpg = new System.Windows.Forms.CheckBox();
            this.listBox_inventory = new System.Windows.Forms.ListBox();
            this.textBox_Level = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Points = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Жизни";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Золото";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Опыт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Урон";
            // 
            // textBox_HP
            // 
            this.textBox_HP.Location = new System.Drawing.Point(62, 16);
            this.textBox_HP.Name = "textBox_HP";
            this.textBox_HP.ReadOnly = true;
            this.textBox_HP.Size = new System.Drawing.Size(100, 20);
            this.textBox_HP.TabIndex = 4;
            // 
            // textBox_GOLD
            // 
            this.textBox_GOLD.Location = new System.Drawing.Point(62, 42);
            this.textBox_GOLD.Name = "textBox_GOLD";
            this.textBox_GOLD.ReadOnly = true;
            this.textBox_GOLD.Size = new System.Drawing.Size(100, 20);
            this.textBox_GOLD.TabIndex = 4;
            // 
            // textBox_EXP
            // 
            this.textBox_EXP.Location = new System.Drawing.Point(62, 68);
            this.textBox_EXP.Name = "textBox_EXP";
            this.textBox_EXP.ReadOnly = true;
            this.textBox_EXP.Size = new System.Drawing.Size(100, 20);
            this.textBox_EXP.TabIndex = 4;
            // 
            // textBox_DMG
            // 
            this.textBox_DMG.Location = new System.Drawing.Point(62, 94);
            this.textBox_DMG.Name = "textBox_DMG";
            this.textBox_DMG.ReadOnly = true;
            this.textBox_DMG.Size = new System.Drawing.Size(100, 20);
            this.textBox_DMG.TabIndex = 4;
            // 
            // button_LOCATION
            // 
            this.button_LOCATION.Location = new System.Drawing.Point(8, 180);
            this.button_LOCATION.Name = "button_LOCATION";
            this.button_LOCATION.Size = new System.Drawing.Size(75, 23);
            this.button_LOCATION.TabIndex = 5;
            this.button_LOCATION.Text = "Карта";
            this.button_LOCATION.UseVisualStyleBackColor = true;
            this.button_LOCATION.Click += new System.EventHandler(this.Button_LOCATION_Click);
            // 
            // button_SHOP
            // 
            this.button_SHOP.Location = new System.Drawing.Point(89, 180);
            this.button_SHOP.Name = "button_SHOP";
            this.button_SHOP.Size = new System.Drawing.Size(75, 23);
            this.button_SHOP.TabIndex = 5;
            this.button_SHOP.Text = "Магазин";
            this.button_SHOP.UseVisualStyleBackColor = true;
            this.button_SHOP.Click += new System.EventHandler(this.Button_SHOP_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // autorpg
            // 
            this.autorpg.AutoSize = true;
            this.autorpg.Location = new System.Drawing.Point(8, 209);
            this.autorpg.Name = "autorpg";
            this.autorpg.Size = new System.Drawing.Size(77, 17);
            this.autorpg.TabIndex = 6;
            this.autorpg.Text = "Авто. РПГ";
            this.autorpg.UseVisualStyleBackColor = true;
            this.autorpg.CheckedChanged += new System.EventHandler(this.Autorpg_CheckedChanged);
            // 
            // listBox_inventory
            // 
            this.listBox_inventory.FormattingEnabled = true;
            this.listBox_inventory.Location = new System.Drawing.Point(190, 13);
            this.listBox_inventory.Name = "listBox_inventory";
            this.listBox_inventory.Size = new System.Drawing.Size(268, 212);
            this.listBox_inventory.TabIndex = 7;
            // 
            // textBox_Level
            // 
            this.textBox_Level.Location = new System.Drawing.Point(62, 120);
            this.textBox_Level.Name = "textBox_Level";
            this.textBox_Level.ReadOnly = true;
            this.textBox_Level.Size = new System.Drawing.Size(100, 20);
            this.textBox_Level.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Уровень";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Очки";
            // 
            // textBox_Points
            // 
            this.textBox_Points.Location = new System.Drawing.Point(62, 146);
            this.textBox_Points.Name = "textBox_Points";
            this.textBox_Points.ReadOnly = true;
            this.textBox_Points.Size = new System.Drawing.Size(100, 20);
            this.textBox_Points.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 212);
            this.button1.TabIndex = 12;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Points);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Level);
            this.Controls.Add(this.listBox_inventory);
            this.Controls.Add(this.autorpg);
            this.Controls.Add(this.button_SHOP);
            this.Controls.Add(this.button_LOCATION);
            this.Controls.Add(this.textBox_DMG);
            this.Controls.Add(this.textBox_EXP);
            this.Controls.Add(this.textBox_GOLD);
            this.Controls.Add(this.textBox_HP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_HP;
        private System.Windows.Forms.TextBox textBox_GOLD;
        private System.Windows.Forms.TextBox textBox_EXP;
        private System.Windows.Forms.TextBox textBox_DMG;
        private System.Windows.Forms.Button button_LOCATION;
        private System.Windows.Forms.Button button_SHOP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox autorpg;
        private System.Windows.Forms.ListBox listBox_inventory;
        private System.Windows.Forms.TextBox textBox_Level;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Points;
        private System.Windows.Forms.Button button1;
    }
}

