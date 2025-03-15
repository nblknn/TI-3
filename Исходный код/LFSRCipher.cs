using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2 {
    internal class LFSRCipher {
        private const int BIT_AMOUNT = 26;
        private int register;
        public List<byte> key { get; set; }
        
        public LFSRCipher(String initialState) {
            if (initialState.Length != BIT_AMOUNT)
                throw new ArgumentException("Размер регистра должен быть равен " + BIT_AMOUNT);
            register = Convert.ToInt32(initialState, 2);
            key = new List<byte>();
        }

        //x26 + x8 + x7 + x + 1

        private byte calcNextBit(int reg) {
            return (byte)(reg >> 25 & 1 ^ reg >> 7 & 1 ^ reg >> 6 & 1 ^ reg & 1);
        }

        private byte GenerateNextKeyByte() {
            byte res = 0, bit = 0;
            for (int i = 1; i <= 8; i++) {
                res <<= 1;
                res += (byte)(register >> (BIT_AMOUNT - 1) & 1);
                bit = calcNextBit(register);
                register <<= 1;
                register += bit;
                register &= (int)Math.Pow(2, BIT_AMOUNT) - 1;
            }
            return res;
        }

        public byte[] Encipher(byte[] plaintext) {
            byte[] ciphertext = new byte[plaintext.Length];
            for (int i = 0; i < plaintext.Length; i++) {
                key.Add(GenerateNextKeyByte());
                ciphertext[i] = (byte)(plaintext[i] ^ key[key.Count - 1]);
            }
            return ciphertext;
        }

        public byte[] Encipher(String text) {
            return Encipher(Encoding.UTF8.GetBytes(text));
        }
    }
}
