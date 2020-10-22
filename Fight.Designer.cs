namespace AvtoRPG
{
    partial class Fight
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
            this.enemylist = new System.Windows.Forms.ListBox();
            this.combatlog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AttackTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // enemylist
            // 
            this.enemylist.FormattingEnabled = true;
            this.enemylist.Location = new System.Drawing.Point(12, 12);
            this.enemylist.Name = "enemylist";
            this.enemylist.Size = new System.Drawing.Size(364, 316);
            this.enemylist.TabIndex = 0;
            // 
            // combatlog
            // 
            this.combatlog.FormattingEnabled = true;
            this.combatlog.Location = new System.Drawing.Point(12, 338);
            this.combatlog.Name = "combatlog";
            this.combatlog.Size = new System.Drawing.Size(529, 95);
            this.combatlog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Жизни";
            // 
            // AttackTimer
            // 
            this.AttackTimer.Enabled = true;
            this.AttackTimer.Interval = 1500;
            this.AttackTimer.Tick += new System.EventHandler(this.AttackTimer_Tick);
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combatlog);
            this.Controls.Add(this.enemylist);
            this.Name = "Fight";
            this.Text = "Fight";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fight_FormClosed);
            this.Load += new System.EventHandler(this.Fight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox enemylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer AttackTimer;
        private System.Windows.Forms.ListBox combatlog;
    }
}