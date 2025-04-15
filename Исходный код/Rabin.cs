using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab3 {
    internal class Rabin {
        public BigInteger p;
        public BigInteger q;
        public BigInteger n;
        public BigInteger b;
        private int blockSize;

        public Rabin(BigInteger p, BigInteger q, BigInteger b) {
       /*     if (p <= 3)
                throw new ArgumentException("p должно быть больше 3!");*/
            if (p % 4 != 3)
                throw new ArgumentException("p должно делиться на 4 с остатком 3!");
            if (!IsPrime(p))
                throw new ArgumentException("p должно быть простым числом!");
        /*    if (q <= 3511)
                throw new ArgumentException("q должно быть больше 3511!");*/
            if (q % 4 != 3)
                throw new ArgumentException("q должно делиться на 4 с остатком 3!");
            if (!IsPrime(q))
                throw new ArgumentException("q должно быть простым числом!");
            this.p = p;
            this.q = q;
            n = p * q;
            if (b >= n)
                throw new ArgumentException("b должно быть меньше n!");
       /*     if (b >= 10533)
                throw new ArgumentException("b должно быть меньше 10533!");*/
            this.b = b;
            blockSize = (int)(BigInteger.Log2(n) / 8) + 1;
        }

        private bool IsPrime(BigInteger x) {
            if (x % 2 == 0) return true;
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 100; i++) {
                BigInteger a = (random.Next() % (x - 2)) + 2;
                if (BigInteger.GreatestCommonDivisor(a, x) != 1)
                    return false;
                if (FastExp(a, x - 1, x) != 1)
                    return false;
            }
            return true;
          /*  double squareroot = Math.Exp(BigInteger.Log(x) / 2);
            for (int i = 2; i < squareroot; i++) {
                if (x % i == 0)
                    return false;
            }
            return true;*/
        }

        public BigInteger[] Encipher(byte[] plainText) {
            BigInteger[] result = new BigInteger[plainText.Length];
            for (int i = 0; i < plainText.Length; i++) {
                result[i] = (plainText[i] * (plainText[i] + b)) % n;
            }
            return result;
        }

        public byte[] CipherTextToBytes(BigInteger[] cipherText) {
            byte[] result = new byte[cipherText.Length * blockSize];
            for (int i = 0; i < result.Length; i += blockSize) {
                for (int j = i + blockSize - 1; j >= i; j--) {
                    result[j] = (byte)(cipherText[i / blockSize] & 0xFF);
                    cipherText[i / blockSize] >>= 8;
                }
            }
            return result;
        }

        public BigInteger[] BytesToCipherText(byte[] byteArr) {
            BigInteger[] result = new BigInteger[byteArr.Length / blockSize + (byteArr.Length % blockSize == 0 ? 0 : 1)];
            for (int j = 0, i = 0; j < result.Length; j++, i += blockSize) {
                for (int k = 0; k < blockSize && (i + k) < byteArr.Length; k++) {
                    result[j] <<= 8;
                    result[j] += byteArr[i + k];
                }
            }
            return result;
        }

        private BigInteger[] EuclidEx(BigInteger a, BigInteger b) {
            BigInteger d0 = a, d1 = b, x0 = 1, x1 = 0, y0 = 0, y1 = 1;
            while (d1 > 1) {
                BigInteger q = d0 / d1;
                BigInteger d2 = d0 % d1;
                BigInteger x2 = x0 - q * x1;
                BigInteger y2 = y0 - q * y1;
                d0 = d1;
                d1 = d2;
                x0 = x1;
                x1 = x2;
                y0 = y1;
                y1 = y2;
            }
            return [x1, y1];
        }

        private BigInteger FastExp(BigInteger a, BigInteger z, BigInteger n) {
            BigInteger a1 = a, z1 = z, x = 1;
            while (z1 != 0) {
                while (z1 % 2 == 0) {
                    z1 /= 2;
                    a1 = (a1 * a1) % n;
                }
                z1--;
                x = (x * a1) % n;
            }
            return x;
        }

        public BigInteger[] GetRoots(BigInteger c) {
            BigInteger D = (b * b + 4 * c) % n;
            BigInteger mp = FastExp(D, (p + 1) / 4, p);
            BigInteger mq = FastExp(D, (q + 1) / 4, q);
            BigInteger[] y = EuclidEx(p, q);
            BigInteger[] d = new BigInteger[4];
            d[0] = (y[0] * p * mq + y[1] * q * mp) % n;
            d[1] = n - d[0];
            d[2] = (y[0] * p * mq - y[1] * q * mp) % n;
            d[3] = n - d[2];
            BigInteger[] m = new BigInteger[4];
            for (int i = 0; i < 4; i++) {
                if ((d[i] - b) % 2 == 0) {
                    m[i] = ((-b + d[i]) / 2) % n;
                }
                else {
                    m[i] = ((-b + n + d[i]) / 2) % n;
                }
            }
            return m;
        }

        public byte[] Decipher(byte[] cipherText) {
            BigInteger[] cipher = BytesToCipherText(cipherText);
            byte[] result = new byte[cipher.Length];

            for (int i = 0; i < cipher.Length; i++) {
                BigInteger[] roots = GetRoots(cipher[i]);
                for (int j = 0; j < roots.Length; j++)
                    if (roots[j] <= 255 && roots[j] >= 0) {
                        result[i] = (byte)roots[j];
                        break;
                    }
            }

            return result;
        }
    }
}
