// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter First Number");
int firstNumber = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter Second Number");
int secondNumber = Convert.ToInt16(Console.ReadLine());

int result = firstNumber + secondNumber;
Console.WriteLine("Addition Of {0} & {1} is {2}", firstNumber, secondNumber, result);

int result1 =  firstNumber - secondNumber;
Console.WriteLine("Subraction Of {0} & {1} is {2}", firstNumber, secondNumber, result1);

int result2 = firstNumber * secondNumber;
Console.WriteLine("Multiplication Of {0} & {1} is {2}", firstNumber, secondNumber, result2);

int  result3 = firstNumber / secondNumber;
Console.WriteLine("Division Of {0} & {1} is {2}", firstNumber, secondNumber, result3);