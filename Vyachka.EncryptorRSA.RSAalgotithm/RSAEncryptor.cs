using System;
using System.Numerics;

namespace Vyachka.EncryptorRSA.RSAalgorithm
{
    public static class RSAEncryptor
    {
        public static short[] Encrypt(byte[] message, BigInteger key, BigInteger r)
        {
            short[] result = new short[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                BigInteger res = Helper.FastExp(message[i], key, r);
                if (res > short.MaxValue)
                {
                    throw new ArithmeticException("Cipher value more than can be written. Please, fix input " +
                                                  "values");
                }

                result[i] = (short)res;
            }

            return result;
        }

        public static byte[] Decrypt(byte[] message, BigInteger key, BigInteger r)
        {
            byte[] result = new byte[message.Length / 2];
            short[] shortArrMessage = Helper.ToShortArray(message);
            for (int i = 0; i < shortArrMessage.Length; i++)
            {
                BigInteger res = Helper.FastExp(shortArrMessage[i], key, r);
                if (res > short.MaxValue)
                {
                    throw new ArithmeticException("Cipher value more than can be written. Please, fix input " +
                                                  "values");
                }

                result[i] = (byte)res;
            }

            return result;
        }
    }
}