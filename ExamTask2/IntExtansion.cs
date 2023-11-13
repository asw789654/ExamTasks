namespace ExamTask2
{
    public static class IntExtansion
    {
        public static string IntInWords(this int str)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var num = 0;
            string newstr = string.Empty;
            while (n > 0)
            {
                num = n % 10;
                if (num == 1)
                {
                    string.Concat(newstr, "один");
                }
                else if (num == 2)
                {
                    string.Concat(newstr, "два");
                }
                else if (num == 3)
                {
                    string.Concat(newstr, "три");
                }
                else if (num == 4)
                {
                    string.Concat(newstr, "четыре");
                }
                else if (num == 5)
                {
                    string.Concat(newstr, "пять");
                }
                else if (num == 6)
                {
                    string.Concat(newstr, "шесть");
                }
                else if (num == 7)
                {
                    string.Concat(newstr, "семь");
                }
                else if (num == 8)
                {
                    string.Concat(newstr, "восемь");
                }
                else if (num == 9)
                {
                    string.Concat(newstr, "демять");
                }

                n /= 10;
            }
            return newstr;
        }
    }
}
