using System.Numerics;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        byte[] plaintext;
        byte[] result;
        Rabin rabin;

        private void btnEncipher_Click(object sender, EventArgs e) {
            if (tbPlaintext.Text == "" || tbP.Text == "" || tbQ.Text == "" || tbB.Text == "") {
                MessageBox.Show("��������� ��� ���� � ��������� ����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try {
                rabin = new Rabin(BigInteger.Parse(tbP.Text), BigInteger.Parse(tbQ.Text), BigInteger.Parse(tbB.Text));
                BigInteger[] ciphertext = rabin.Encipher(plaintext);
                tbCiphertext.Text = String.Join(" ", ciphertext);
                result = rabin.CipherTextToBytes(ciphertext);
            }
            catch (ArgumentException exc) {
                MessageBox.Show(exc.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecipher_Click(object sender, EventArgs e) {
            if (tbPlaintext.Text == "" || tbP.Text == "" || tbQ.Text == "" || tbB.Text == "") {
                MessageBox.Show("��������� ��� ���� � ��������� ����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try {
                rabin = new Rabin(BigInteger.Parse(tbP.Text), BigInteger.Parse(tbQ.Text), BigInteger.Parse(tbB.Text));
                result = rabin.Decipher(plaintext);
                tbCiphertext.Text = String.Join(" ", result);
                tbPlaintext.Text = String.Join(" ", rabin.BytesToCipherText(plaintext));
            }
            catch (ArgumentException exc) {
                MessageBox.Show(exc.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            plaintext = File.ReadAllBytes(openFileDialog.FileName);
            tbPlaintext.Text = String.Join(" ", plaintext);
            tbCiphertext.Text = "";
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            using (BinaryWriter writer = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.Create)))
                writer.Write(result, 0, result.Length);
        }

        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e) {
            MessageBox.Show("������ ��������� ��������� �������� �� ���������\n������ ��� ����� � ����� ����������.\n" +
                "���������:\np: ������� �����; p mod 4 = 3\n" +
                "q: ������� �����; q mod 4 = 3\nb: b < n = p * q\n"+
                "��� ���������� ����������� ���������� ������������\np > 3; q > 3511; 0 < b < 10533", "� ���������");
        }

        private void baseKeyPress(object sender, KeyPressEventArgs e) {
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9' && (sender as TextBox).Text.Length < 10)))
                e.KeyChar = '\0';
        }

        private void tbP_TextChanged(object sender, EventArgs e) {
            if (tbP.Text != "" && tbQ.Text != "")
                tbN.Text = (BigInteger.Parse(tbP.Text) * BigInteger.Parse(tbQ.Text)).ToString();
            else
                tbN.Text = "";
        }
    }
}
