using System.Collections;

namespace ExamTask1
{
    internal class MyStack
    {
        private int[] numbers = new int[0];

        public MyStack(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int[] Numbers 
        {
            get { return numbers; }
            set { numbers = value; }
        }

        public int pop()
        {
            int number = numbers[numbers.Length - 1];
            int[] newnumbers = new int[numbers.Length - 1];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                newnumbers[i] = numbers[i];
            }
            numbers = newnumbers;
            return number;
        }

        public void push(int number)
        {
            int[] newnumbers = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                newnumbers[i] = numbers[i];
            }
            numbers = newnumbers;
            numbers[numbers.Length - 1] = number;
            Console.WriteLine($"Добавлен элемент {number}");
        }
    }
}
