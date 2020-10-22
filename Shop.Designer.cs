namespace AvtoRPG
{
    partial class Shop
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Pokypka = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.ShopTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 303);
            this.listBox1.TabIndex = 0;
            // 
            // button_Pokypka
            // 
            this.button_Pokypka.Location = new System.Drawing.Point(197, 321);
            this.button_Pokypka.Name = "button_Pokypka";
            this.button_Pokypka.Size = new System.Drawing.Size(75, 23);
            this.button_Pokypka.TabIndex = 1;
            this.button_Pokypka.Text = "Купить";
            this.button_Pokypka.UseVisualStyleBackColor = true;
            this.button_Pokypka.Click += new System.EventHandler(this.Button_Pokypka_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.Location = new System.Drawing.Point(12, 321);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(75, 23);
            this.button_EXIT.TabIndex = 2;
            this.button_EXIT.Text = "Выход";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // ShopTimer
            // 
            this.ShopTimer.Enabled = true;
            this.ShopTimer.Interval = 3000;
            this.ShopTimer.Tick += new System.EventHandler(this.ShopTimer_Tick);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 353);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.button_Pokypka);
            this.Controls.Add(this.listBox1);
            this.Name = "Shop";
            this.Text = "Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Shop_FormClosed);
            this.Load += new System.EventHandler(this.Shop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Pokypka;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.Timer ShopTimer;
    }
}