Console.WriteLine("Программа для арифметический действий двух чисел");
string message = "Любая клавиша - Продолжить" + '\n' + "\"Esc\" - Закончить";
do
{
    try
    {
        Console.WriteLine("Введите выражение");
        string expression = Console.ReadLine();
        char[] operators = ['*', ':', '/', '%', '√', '+', '-'];
        var i = -1;
        foreach (char Operator in operators)
        {
            i = expression.IndexOf(Operator, 1);
            if (Operator == '√') i = expression.IndexOf(Operator);
            if (i >= 0) break;
        }
        string isOperator = expression.Substring(i, 1);
        var isNumber1 = 1.23;
        if (isOperator != "√")
        {
            string number1 = expression.Substring(0, i);
            isNumber1 = float.Parse(number1);
        }
        string number2 = expression.Substring(i + 1);
        var isNumber2 = float.Parse(number2);
        if (isNumber2 == 0 && isOperator == "/" || isNumber2 == 0 && isOperator == ":")
        {
            Console.WriteLine("На 0 делить нельзя" + '\n' + message);

            continue;
        }
        var result = isOperator switch
        {
            "+" => isNumber1 + isNumber2,
            "-" => isNumber1 - isNumber2,
            "*" => isNumber1 * isNumber2,
            ":" => isNumber1 / isNumber2,
            "/" => isNumber1 / isNumber2,
            "%" => isNumber1 / 100 * isNumber1,
            "√" => Math.Sqrt(isNumber2)

        };
        Console.WriteLine("Результат = " + result + '\n' + message);
    }
    catch
    {
        Console.WriteLine("Неверный формат " + '\n' + message);
    }
} while (Console.ReadKey(true).Key != ConsoleKey.Escape);