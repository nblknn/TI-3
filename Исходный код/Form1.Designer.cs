namespace lab2
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
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            programInfoToolStripMenuItem = new ToolStripMenuItem();
            lbInitialState = new Label();
            tbInitialState = new TextBox();
            tbPlainText = new TextBox();
            lbPlainText = new Label();
            btnCipher = new Button();
            lbKey = new Label();
            tbKey = new TextBox();
            tbResult = new TextBox();
            lbResult = new Label();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, programInfoToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1128, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(216, 26);
            openToolStripMenuItem.Text = "Открыть...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(216, 26);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(213, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(216, 26);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // programInfoToolStripMenuItem
            // 
            programInfoToolStripMenuItem.Name = "programInfoToolStripMenuItem";
            programInfoToolStripMenuItem.Size = new Size(118, 24);
            programInfoToolStripMenuItem.Text = "О программе";
            programInfoToolStripMenuItem.Click += programInfoToolStripMenuItem_Click;
            // 
            // lbInitialState
            // 
            lbInitialState.AutoSize = true;
            lbInitialState.Location = new Point(12, 38);
            lbInitialState.Name = "lbInitialState";
            lbInitialState.Size = new Size(231, 20);
            lbInitialState.TabIndex = 1;
            lbInitialState.Text = "Начальное состояние регистра:";
            // 
            // tbInitialState
            // 
            tbInitialState.Location = new Point(12, 61);
            tbInitialState.Name = "tbInitialState";
            tbInitialState.Size = new Size(358, 27);
            tbInitialState.TabIndex = 2;
            tbInitialState.KeyPress += textBox1_KeyPress;
            // 
            // tbPlainText
            // 
            tbPlainText.Location = new Point(12, 117);
            tbPlainText.Multiline = true;
            tbPlainText.Name = "tbPlainText";
            tbPlainText.ReadOnly = true;
            tbPlainText.ScrollBars = ScrollBars.Vertical;
            tbPlainText.Size = new Size(358, 326);
            tbPlainText.TabIndex = 3;
            // 
            // lbPlainText
            // 
            lbPlainText.AutoSize = true;
            lbPlainText.Location = new Point(12, 94);
            lbPlainText.Name = "lbPlainText";
            lbPlainText.Size = new Size(121, 20);
            lbPlainText.TabIndex = 4;
            lbPlainText.Text = "Исходный текст:";
            // 
            // btnCipher
            // 
            btnCipher.Location = new Point(385, 60);
            btnCipher.Name = "btnCipher";
            btnCipher.Size = new Size(231, 29);
            btnCipher.TabIndex = 5;
            btnCipher.Text = "Зашифровать/дешифровать";
            btnCipher.UseVisualStyleBackColor = true;
            btnCipher.Click += button1_Click;
            // 
            // lbKey
            // 
            lbKey.AutoSize = true;
            lbKey.Location = new Point(385, 94);
            lbKey.Name = "lbKey";
            lbKey.Size = new Size(181, 20);
            lbKey.TabIndex = 7;
            lbKey.Text = "Сгенерированный ключ:";
            // 
            // tbKey
            // 
            tbKey.Location = new Point(385, 117);
            tbKey.Multiline = true;
            tbKey.Name = "tbKey";
            tbKey.ReadOnly = true;
            tbKey.ScrollBars = ScrollBars.Vertical;
            tbKey.Size = new Size(358, 326);
            tbKey.TabIndex = 8;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(759, 117);
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.ScrollBars = ScrollBars.Vertical;
            tbResult.Size = new Size(358, 326);
            tbResult.TabIndex = 9;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(759, 94);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(78, 20);
            lbResult.TabIndex = 10;
            lbResult.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1128, 455);
            Controls.Add(lbResult);
            Controls.Add(tbResult);
            Controls.Add(tbKey);
            Controls.Add(lbKey);
            Controls.Add(btnCipher);
            Controls.Add(lbPlainText);
            Controls.Add(tbPlainText);
            Controls.Add(tbInitialState);
            Controls.Add(lbInitialState);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ТИ лаб. 2";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem programInfoToolStripMenuItem;
        private Label lbInitialState;
        private TextBox tbInitialState;
        private TextBox tbPlainText;
        private Label lbPlainText;
        private Button btnCipher;
        private Label lbKey;
        private TextBox tbKey;
        private TextBox tbResult;
        private Label lbResult;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}
