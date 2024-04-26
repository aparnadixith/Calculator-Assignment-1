// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("My Calculator");
{
    Console.ForegroundColor = ConsoleColor.Red;


    int num1;
    int num2;
    int result;


    Console.WriteLine(" Enter the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(" Enter the second number:");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the operation(+,-,*,/):");


    switch (Console.ReadLine())
    {

        case "+":
            result = num1 + num2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" The answer is  " + result);
            break;

        case "-":
            result = num1 - num2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" The answer is  " + result);
            break;

        case "*":
            result = num1 * num2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" The answer is " + result);
            break;

        case "/":

            if (num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine(" The answer is " + result);
            }
            else
            {
                Console.WriteLine(" The division is wrong");


            }
            break;




    }

    Console.ReadKey();
}

