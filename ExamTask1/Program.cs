using ExamTask1;

int[] numbers = { 1, 2, 3 };
MyStack myStack = new MyStack(numbers);
//myStack.push(2);
myStack.pop();
for (int i = 0; i < myStack.Numbers.Length; i++)
{
    Console.WriteLine(myStack.Numbers[i]);
}