
// See https://aka.ms/new-console-template for more information

/*

*/

bool condition = true;

calculatorBrain();
void calculatorBrain()
{
    while (condition)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Title = "==== Simple Console Calculator =====";
        Console.ResetColor();
        Console.WriteLine("Welcome to the dashboard \n Operations you can perform");
        Console.Write("Addition\tSubtraction\tMultiplication\tDivision\tModulo\n");
        try
        {
            Console.Write("First number: ");
            double firstNumber = convertToDouble(Console.ReadLine()!);
            Console.WriteLine("What operation do you want to perform: ");
            string operation = Console.ReadLine()!;
            Console.Write("Second number: ");
            double secondNumber = convertToDouble(Console.ReadLine()!);
            Console.Write("the result is " + calculatorEngine(firstNumber, secondNumber, operation));
            string userChoice;
            string yes = "y";
            string no = "n";
            do
            {
                Console.Beep();
                Console.WriteLine("\nDo you want to continue(y/n): ");
                userChoice = Console.ReadLine()!;
            } while (!userChoice.Equals(yes, StringComparison.OrdinalIgnoreCase) && !userChoice.Equals(no, StringComparison.OrdinalIgnoreCase));
            if (userChoice.ToLower() == no)
            {
                Console.WriteLine("You stopped the calculator Succesfully");
                condition = false;
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("An error Occured " + ex.Message);
        }

    }

    return;
}

double calculatorEngine(double firstNumber, double secondNumber, string argoperator)
{
    double result = 0;

    switch (argoperator.ToLower())
    {
        case "+":
        case "add":
            result = firstNumber + secondNumber;
            break;
        case "-":
        case "minus":
            result = firstNumber - secondNumber;
            break;
        case "*":
        case "multiply":
            result = firstNumber * secondNumber;
            break;
        case "/":
        case "divide":
            result = firstNumber / secondNumber;
            break;
        case "%":
        case "modulo":
            result = firstNumber % secondNumber;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No operator specified");
            Console.ResetColor();
            break;

    }
    return result;

}

double convertToDouble(string number)
{
    if (!double.TryParse(number, out double convertedNumber))
    {
        throw new FormatException("Excepted a numeric value");
    }
    return convertedNumber;
}


// try
// {
//     while (condition)
//     {
//         Console.ForegroundColor = ConsoleColor.DarkGreen;
//         Console.WriteLine("==== Simple Console Calculator =====");
//         Console.ResetColor();
//         Console.WriteLine("Welcome to the dashboard \n what operation do you want to perform");
//         Console.Write("1.Addition\t2.Subtraction\t3.Multiplication\t4.Division: ");
//         int UserChoice = Convert.ToInt32(Console.ReadLine()!);
//         double firstNumber;
//         double secondNumber;

// double result;


// Console.Write("\n What is your first operand: ");
// firstNumber = convertToDouble(Console.ReadLine()!);
// Console.Write("\n What is your second operand: ");
// secondNumber = convertToDouble(Console.ReadLine()!);
// switch (UserChoice)
// {
//     // case 1:
//     Console.WriteLine($"The Addition of {firstNumber} + {secondNumber} = {Addition(firstNumber, secondNumber)} ");
//     break;

// case 2:
//     Console.Write("\n What is your first operand: ");
//     firstNumber = Convert.ToDouble(Console.ReadLine());
//     Console.Write("\n What is your second operand: ");
//     secondNumber = Convert.ToDouble(Console.ReadLine());
//     result = firstNumber - secondNumber;
//     result = Math.Round(result, 4);
//     Console.WriteLine($"The Subtraction of {firstNumber} - {secondNumber} = {result} ");
//     break;

// case 3:
//     Console.Write("\n What is your first operand: ");
//     firstNumber = Convert.ToDouble(Console.ReadLine());
//     Console.Write("\n What is your second operand: ");
//     secondNumber = Convert.ToDouble(Console.ReadLine());
//     result = firstNumber * secondNumber;
//     result = Math.Round(result, 4);
//     Console.WriteLine($"The Multiplication of {firstNumber} x {secondNumber} = {result} ");
//     break;
// case 4:
//     try
//     {

//         Console.Write("\n What is your first operand: ");
//         firstNumber = Convert.ToDouble(Console.ReadLine());
//         Console.Write("\n What is your second operand: ");
//         secondNumber = Convert.ToDouble(Console.ReadLine());
//         result = firstNumber / secondNumber;
//         result = Math.Round(result, 4);
//         Console.WriteLine($"The Division of {firstNumber} / {secondNumber} = {result}");
//         break;
//     }
//     catch (DivideByZeroException d)
//     {
//         Console.WriteLine($"Division = {d} ");
//         break;
//     }
//             default:
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 throw new ArgumentException("Invalid Operation");
//         }
//         string choice;
//         string yes = "y";
//         do
//         {
//             Console.Write("Do you want to Calculate again(y/n): ");
//             choice = Console.ReadLine()!;

//         } while (!choice.Equals("y", StringComparison.OrdinalIgnoreCase) && !choice.Equals("n", StringComparison.OrdinalIgnoreCase));
//         if (choice != yes)
//         {
//             break;
//         }



//     }
// }
// catch (FormatException)
// {
//     Console.ForegroundColor = ConsoleColor.DarkRed;
//     Console.WriteLine("Cannot convert letters or symbols to number");

// }
// catch (Exception)true
// {
//     Console.ForegroundColor = ConsoleColor.DarkRed;
//     Console.WriteLine("You entered the wrong input");
// }