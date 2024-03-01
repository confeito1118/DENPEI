namespace DENPEI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            closeWToolStripMenuItem = new ToolStripMenuItem();
            checkCToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            versionVToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 13.8F);
            label1.Location = new Point(253, 76);
            label1.Name = "label1";
            label1.Size = new Size(200, 23);
            label1.TabIndex = 1;
            label1.Text = "しばらくお待ちください";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 13.8F);
            label2.Location = new Point(253, 99);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 2;
            label2.Text = "しばらくお待ちください";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS UI Gothic", 13.8F);
            label3.Location = new Point(253, 122);
            label3.Name = "label3";
            label3.Size = new Size(200, 23);
            label3.TabIndex = 3;
            label3.Text = "しばらくお待ちください";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS UI Gothic", 13.8F);
            label4.Location = new Point(253, 145);
            label4.Name = "label4";
            label4.Size = new Size(200, 23);
            label4.TabIndex = 4;
            label4.Text = "しばらくお待ちください";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS UI Gothic", 13.8F);
            label5.Location = new Point(253, 168);
            label5.Name = "label5";
            label5.Size = new Size(200, 23);
            label5.TabIndex = 5;
            label5.Text = "しばらくお待ちください";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, checkCToolStripMenuItem, versionVToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(796, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeWToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(82, 24);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // closeWToolStripMenuItem
            // 
            closeWToolStripMenuItem.Name = "closeWToolStripMenuItem";
            closeWToolStripMenuItem.Size = new Size(153, 26);
            closeWToolStripMenuItem.Text = "閉じる(&W)";
            closeWToolStripMenuItem.Click += closeWToolStripMenuItem_Click;
            // 
            // checkCToolStripMenuItem
            // 
            checkCToolStripMenuItem.Name = "checkCToolStripMenuItem";
            checkCToolStripMenuItem.Size = new Size(113, 24);
            checkCToolStripMenuItem.Text = "手動チェック(&C)";
            checkCToolStripMenuItem.Click += checkCToolStripMenuItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS UI Gothic", 13.8F);
            label6.Location = new Point(51, 76);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 7;
            label6.Text = "AC電源：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS UI Gothic", 13.8F);
            label7.Location = new Point(51, 99);
            label7.Name = "label7";
            label7.Size = new Size(123, 23);
            label7.TabIndex = 8;
            label7.Text = "充電レベル：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS UI Gothic", 13.8F);
            label8.Location = new Point(51, 122);
            label8.Name = "label8";
            label8.Size = new Size(150, 23);
            label8.TabIndex = 9;
            label8.Text = "バッテリー残量：";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MS UI Gothic", 13.8F);
            label9.Location = new Point(51, 145);
            label9.Name = "label9";
            label9.Size = new Size(187, 23);
            label9.TabIndex = 10;
            label9.Text = "バッテリー残り時間：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("MS UI Gothic", 13.8F);
            label10.Location = new Point(51, 168);
            label10.Name = "label10";
            label10.Size = new Size(196, 23);
            label10.TabIndex = 11;
            label10.Text = "バッテリー駆動時間：";
            // 
            // versionVToolStripMenuItem
            // 
            versionVToolStripMenuItem.Name = "versionVToolStripMenuItem";
            versionVToolStripMenuItem.Size = new Size(96, 24);
            versionVToolStripMenuItem.Text = "バージョン(&V)";
            versionVToolStripMenuItem.Click += versionVToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 238);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "でんぺい";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem closeWToolStripMenuItem;
        private ToolStripMenuItem checkCToolStripMenuItem;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ToolStripMenuItem versionVToolStripMenuItem;
    }
}
