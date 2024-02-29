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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            閉じるWToolStripMenuItem = new ToolStripMenuItem();
            checkCToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 84);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "しばらくお待ちください";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 117);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 2;
            label2.Text = "しばらくお待ちください";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 149);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 3;
            label3.Text = "しばらくお待ちください";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 182);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 4;
            label4.Text = "しばらくお待ちください";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 214);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 5;
            label5.Text = "しばらくお待ちください";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, checkCToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(697, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 閉じるWToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(82, 24);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 閉じるWToolStripMenuItem
            // 
            閉じるWToolStripMenuItem.Name = "閉じるWToolStripMenuItem";
            閉じるWToolStripMenuItem.Size = new Size(153, 26);
            閉じるWToolStripMenuItem.Text = "閉じる(&W)";
            // 
            // checkCToolStripMenuItem
            // 
            checkCToolStripMenuItem.Name = "checkCToolStripMenuItem";
            checkCToolStripMenuItem.Size = new Size(83, 24);
            checkCToolStripMenuItem.Text = "チェック(&C)";
            checkCToolStripMenuItem.Click += checkCToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 290);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
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
        private ToolStripMenuItem 閉じるWToolStripMenuItem;
        private ToolStripMenuItem checkCToolStripMenuItem;
    }
}
