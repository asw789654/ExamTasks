namespace ExamTask2
{
    public static class IntExtansion
    {
        public static int IntInWords(this int str)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var num = 0;
            string srt;
            while (n > 0)
            {
                num = n % 10;
                if (num == 1)
                {
                    string.Concat(str,"один");
                }
                else if (num == 2)
                {
                    string.Concat(str, "два");
                }
                else if (num == 3)
                {
                    string.Concat(str, "три");
                }
                else if (num == 4)
                {
                    string.Concat(str, "четыре");
                }
                else if (num == 5)
                {
                    string.Concat(str, "пять");
                }
                else if (num == 6)
                {
                    string.Concat(str, "шесть");
                }
                else if (num == 7)
                {
                    string.Concat(str, "семь");
                }
                else if (num == 8)
                {
                    string.Concat(str, "восемь");
                }
                else if (num == 9)
                {
                    string.Concat(str, "демять");
                }

                n /= 10;
            }
            return str;
        }
    }
}
