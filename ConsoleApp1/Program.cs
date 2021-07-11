using System;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
     
        public  Program(string low, string high )
        {
            ArrayList validPass = new ArrayList();
            int currentPassword = int.Parse(low);
            int endingPassword = int.Parse(high);

            while (currentPassword <= endingPassword)
            {
               int [] currentPasswordDigit = convertToDigit(currentPassword);
                if (meetCriteria(currentPasswordDigit))
                {
                    Console.WriteLine("[{0}]", string.Join(",",currentPasswordDigit));
                    
                    validPass.Add(currentPassword);
                }

                currentPassword++;

            }

            Console.WriteLine("Password combination : "+validPass.Count);
        }

        public bool meetCriteria (int [] password)
        {
            if (!checkDigit(password))
                return false;
            return checkIncreaseDigit(password);
        }

        public bool checkDigit (int [] password)
        {
            for (int i = 1; i < password.Length; i++)
                if (password[i] == password[i - 1])
                    return true;
            return false;
        }

        public bool checkIncreaseDigit (int [] password)
        {
            for (int i = 1; i < password.Length; i++)
                if (password[i] < password[i - 1])
                    return false;
            return true;
        }
        public int[] convertToDigit(int pass)
        {
            return convertToDigit(pass.ToString());
        }
        public int [] convertToDigit (string passString)
        {
            int[] digit = new int[6];
            for (int i = 0; i < digit.Length; i++)
                digit[i] = int.Parse(passString.Substring(i, 1));
            return digit;
        }
        static void Main(string[] args)
        {

            string rangeFrom = "271973";

            string rangeTo = "785961";

            new Program(rangeFrom, rangeTo);

        }
    }
}
