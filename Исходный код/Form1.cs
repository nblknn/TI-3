namespace lab2
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ciphertext = Array.Empty<byte>();
            plaintext = Array.Empty<byte>();
        }

        const int BIT_AMOUNT = 26;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '\b') || (tbInitialState.Text.Length >= BIT_AMOUNT && e.KeyChar != '\b')) {
                e.KeyChar = '\0';
            }
        }

        LFSRCipher lfsr;
        byte[] ciphertext;
        byte[] plaintext;

        private String bytesToBinString(byte[] arr) {
            String res = "";
            for (int i = 0; i < arr.Length; i++) {
                String cbyte = Convert.ToString(arr[i], 2);
                while (cbyte.Length < 8)
                    cbyte = '0' + cbyte;
                res += cbyte;
            }
            return res;
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                lfsr = new LFSRCipher(tbInitialState.Text);
            }
            catch (ArgumentException exc) {
                MessageBox.Show(exc.Message);
                return;
            }
            ciphertext = lfsr.Encipher(plaintext);
            tbKey.Text = bytesToBinString(lfsr.key.ToArray());
            tbResult.Text = bytesToBinString(ciphertext);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            using (BinaryWriter writer = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.Create)))
                writer.Write(ciphertext, 0, ciphertext.Length);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            plaintext = File.ReadAllBytes(openFileDialog.FileName);
            tbPlainText.Text = bytesToBinString(plaintext);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void programInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Разработчик: Городко Ксения, группа 351003, вариант 4\n" +
                "Данная программа выполняет потоковое шифрование и дешифрование\n" +
                "файла с помощью генератора ключевой последовательности на основе\n" +
                "линейного сдвигового регистра с обратной связью LFSR разрядности " + BIT_AMOUNT + ".", "О программе");

        }
    }
}
