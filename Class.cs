using System;
using System.Linq;

namespace methods
{
     public class Class
    {
         public static int[] convert(char[] inputArr)
        {
            var intArr = new int[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            { intArr[i] = Convert.ToInt32(inputArr[i]) - 48; }
            return intArr;
        }

        public static string Output(int[] Key, int[] Msg)
        {
            int j = 0;
            string Out="";
            int[] result = new int[Msg.Length];
            for (int i = 0; i < Msg.Length; i++)
            {
                if (j > 9) j = 0;
                result[i] = Key[j] + Msg[i];
                if (result[i] > 9) result[i] -= 10;
                j++;
                Out+=(result[i].ToString());
            }
            return Out;
        }

        public static void checkKey(string encKey,int [] encKeyArr)
        {
            bool key = (encKey.ToCharArray()).All(char.IsDigit);
            if (!key) throw new Exception("invalid encryption key!\ncan not be enter character!");
            if (encKeyArr.Length != 10) throw new Exception("invalid encryption key!\nenter 10 numbers only!");
            for (int i = 0; i < encKeyArr.Length; i++)
                for (int j = i; j < encKeyArr.Length - 1; j++)
                    if (encKeyArr[j] == encKeyArr[j + 1]) throw new Exception("invalid encryption key!\nduplicate number!");

        }

        public static void checkMsg(string msg)
        {
            bool number = (msg.ToCharArray()).All(char.IsDigit);
            if (!number)throw new Exception("invalid number!\ncannot enter character!");

        }

    }
}
