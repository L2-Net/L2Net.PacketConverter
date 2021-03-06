﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L2Net.PacketConverter.Core
{
    public static class Convert
    {
        public static string FromByteToHex(byte i)
        {
            return FromNumberToHex(i, 1);
        }

        public static string FromInt16ToHex(Int16 i)
        {
            return FromNumberToHex(i, 2);
        }

        public static string FromInt32ToHex(Int32 i)
        {
            return FromNumberToHex(i, 4);
        }

        public static string FromInt64ToHex(long i)
        {
            return FromNumberToHex(i, 8);
        }

        private static string FromNumberToHex(long i, int size)
        {
            return FromNumberToHex(BitConverter.GetBytes(i), size);
        }

        private static string FromNumberToHex(byte[] i, int size)
        {
            return BitConverter.ToString(i.Take(size).ToArray()).NormalizeString();
        }

        public static byte FromHexToByte(string hex)
        {
            return System.Convert.ToByte(hex.Substring(0, 2), 16);
        }

        public static int FromHexToInt16(string hex)
        {
            return BitConverter.ToInt16(FromHexToBytes(hex, 4), 0) is Int16 n && n == -1 ? int.MaxValue : n;
        }

        public static int FromHexToInt32(string hex)
        {
            return
                BitConverter.ToInt32(FromHexToBytes(hex, 8), 0) is Int32 n && n == -1 ? Int32.MaxValue : n;
        }

        public static long FromHexToInt64(string hex)
        {
            return
                BitConverter.ToInt64(FromHexToBytes(hex, 16), 0) is Int64 n && n == -1 ? Int64.MaxValue : n;
        }

        public static byte[] FromHexToBytes(string hex, int size)
        {
            hex = hex.RemoveSeparators();
            if (hex.Length < size)
            {
                var sb = new StringBuilder(hex);
                while (sb.Length < size)
                {
                    sb.Append("00");
                }
                hex = sb.ToString();
            }
            byte[] raw = new byte[size];
            for (int i = 0; i < raw.Length / 2; i++)
            {
                raw[i] = System.Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }

        public static string FromStringToHex(string str, bool separateLetters = true)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            if (separateLetters)
            {
                bytes = SeparateLetters(bytes);
            }
            return BitConverter.ToString(bytes).NormalizeString();
        }

        public static string FromHexToString(string hex)
        {
            hex = hex.RemoveSeparators();
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = System.Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            raw = raw.Where(x => x != byte.MinValue).ToArray();
            return Encoding.ASCII.GetString(raw);
        }

        private static byte[] SeparateLetters(byte[] array)
        {
            List<byte> newArray = new List<byte>();
            array.ToList().ForEach(b =>
            {
                newArray.Add(b);
                newArray.Add(0);
            });
            return newArray.ToArray();
        }

    }
}
