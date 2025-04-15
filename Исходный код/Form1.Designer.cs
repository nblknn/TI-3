namespace lab3
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
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            ыЫЫToolStripMenuItem = new ToolStripMenuItem();
            openPlainTextToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem1 = new ToolStripMenuItem();
            tbP = new TextBox();
            tbQ = new TextBox();
            tbB = new TextBox();
            tbN = new TextBox();
            tbPlaintext = new TextBox();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbCiphertext = new TextBox();
            btnEncipher = new Button();
            btnDecipher = new Button();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ыЫЫToolStripMenuItem, оПрограммеToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(682, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ыЫЫToolStripMenuItem
            // 
            ыЫЫToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openPlainTextToolStripMenuItem, сохранитьToolStripMenuItem });
            ыЫЫToolStripMenuItem.ForeColor = Color.Black;
            ыЫЫToolStripMenuItem.Name = "ыЫЫToolStripMenuItem";
            ыЫЫToolStripMenuItem.Size = new Size(59, 23);
            ыЫЫToolStripMenuItem.Text = "Файл";
            // 
            // openPlainTextToolStripMenuItem
            // 
            openPlainTextToolStripMenuItem.Name = "openPlainTextToolStripMenuItem";
            openPlainTextToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openPlainTextToolStripMenuItem.Size = new Size(223, 26);
            openPlainTextToolStripMenuItem.Text = "Открыть...";
            openPlainTextToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(223, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem1
            // 
            оПрограммеToolStripMenuItem1.ForeColor = Color.Black;
            оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            оПрограммеToolStripMenuItem1.Size = new Size(116, 23);
            оПрограммеToolStripMenuItem1.Text = "О программе";
            оПрограммеToolStripMenuItem1.Click += оПрограммеToolStripMenuItem1_Click;
            // 
            // tbP
            // 
            tbP.Location = new Point(51, 43);
            tbP.Name = "tbP";
            tbP.Size = new Size(231, 27);
            tbP.TabIndex = 1;
            tbP.TextChanged += tbP_TextChanged;
            tbP.KeyPress += baseKeyPress;
            // 
            // tbQ
            // 
            tbQ.Location = new Point(51, 77);
            tbQ.Name = "tbQ";
            tbQ.Size = new Size(231, 27);
            tbQ.TabIndex = 2;
            tbQ.TextChanged += tbP_TextChanged;
            tbQ.KeyPress += baseKeyPress;
            // 
            // tbB
            // 
            tbB.Location = new Point(51, 110);
            tbB.Name = "tbB";
            tbB.Size = new Size(231, 27);
            tbB.TabIndex = 3;
            tbB.KeyPress += baseKeyPress;
            // 
            // tbN
            // 
            tbN.Location = new Point(438, 43);
            tbN.Name = "tbN";
            tbN.ReadOnly = true;
            tbN.Size = new Size(230, 27);
            tbN.TabIndex = 4;
            // 
            // tbPlaintext
            // 
            tbPlaintext.Location = new Point(14, 167);
            tbPlaintext.Multiline = true;
            tbPlaintext.Name = "tbPlaintext";
            tbPlaintext.ReadOnly = true;
            tbPlaintext.ScrollBars = ScrollBars.Vertical;
            tbPlaintext.Size = new Size(316, 210);
            tbPlaintext.TabIndex = 6;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(32, 19);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 46);
            label1.Name = "label1";
            label1.Size = new Size(31, 19);
            label1.TabIndex = 7;
            label1.Text = "p =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(31, 19);
            label2.TabIndex = 8;
            label2.Text = "q =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 113);
            label3.Name = "label3";
            label3.Size = new Size(31, 19);
            label3.TabIndex = 9;
            label3.Text = "b =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 46);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 10;
            label4.Text = "n = p * q =";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 145);
            label6.Name = "label6";
            label6.Size = new Size(128, 19);
            label6.TabIndex = 13;
            label6.Text = "Исходный текст:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 145);
            label7.Name = "label7";
            label7.Size = new Size(82, 19);
            label7.TabIndex = 15;
            label7.Text = "Результат:";
            // 
            // tbCiphertext
            // 
            tbCiphertext.Location = new Point(352, 167);
            tbCiphertext.Multiline = true;
            tbCiphertext.Name = "tbCiphertext";
            tbCiphertext.ReadOnly = true;
            tbCiphertext.ScrollBars = ScrollBars.Vertical;
            tbCiphertext.Size = new Size(316, 210);
            tbCiphertext.TabIndex = 14;
            // 
            // btnEncipher
            // 
            btnEncipher.BackColor = Color.YellowGreen;
            btnEncipher.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnEncipher.FlatAppearance.MouseDownBackColor = Color.GreenYellow;
            btnEncipher.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
            btnEncipher.FlatStyle = FlatStyle.Flat;
            btnEncipher.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnEncipher.ForeColor = Color.DarkOliveGreen;
            btnEncipher.Location = new Point(352, 76);
            btnEncipher.Name = "btnEncipher";
            btnEncipher.Size = new Size(316, 28);
            btnEncipher.TabIndex = 16;
            btnEncipher.Text = "Шифрование";
            btnEncipher.UseVisualStyleBackColor = false;
            btnEncipher.Click += btnEncipher_Click;
            // 
            // btnDecipher
            // 
            btnDecipher.BackColor = Color.YellowGreen;
            btnDecipher.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnDecipher.FlatAppearance.MouseDownBackColor = Color.GreenYellow;
            btnDecipher.FlatAppearance.MouseOverBackColor = Color.GreenYellow;
            btnDecipher.FlatStyle = FlatStyle.Flat;
            btnDecipher.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnDecipher.ForeColor = Color.DarkOliveGreen;
            btnDecipher.Location = new Point(352, 110);
            btnDecipher.Name = "btnDecipher";
            btnDecipher.Size = new Size(316, 28);
            btnDecipher.TabIndex = 17;
            btnDecipher.Text = "Дешифрование";
            btnDecipher.UseVisualStyleBackColor = false;
            btnDecipher.Click += btnDecipher_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(682, 386);
            Controls.Add(tbP);
            Controls.Add(tbQ);
            Controls.Add(btnDecipher);
            Controls.Add(tbB);
            Controls.Add(label3);
            Controls.Add(btnEncipher);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(tbCiphertext);
            Controls.Add(label6);
            Controls.Add(tbPlaintext);
            Controls.Add(tbN);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ТИ лаб. 3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ыЫЫToolStripMenuItem;
        private TextBox tbP;
        private TextBox tbQ;
        private TextBox tbB;
        private TextBox tbN;
        private TextBox tbPlaintext;
        private ToolStripMenuItem openPlainTextToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox tbCiphertext;
        private Button btnEncipher;
        private Button btnDecipher;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}
