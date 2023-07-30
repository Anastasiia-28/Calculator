namespace Calculator
{
    public class Calculator
    {
        private static double x = 0, y = 0;
        private static string operation = string.Empty;

        public static void StartCalculate()
        {
            do
            {
                Console.WriteLine("Оберіть операцію (+, -, *, /, pow, sqrt): ");

                operation = Console.ReadLine();

                GetOperandsAndCalculate();

            } while (ContinueСalculation());
        }

        private static void GetOperandsAndCalculate()
        {
            switch (operation)
            {
                case "+":
                    x = GetNumber("Введіть перший доданок: ");
                    y = GetNumber("Введіть другий доданок: ");

                    Console.WriteLine($"Результат: {x + y}");

                    break;

                case "-":
                    x = GetNumber("Введіть зменшуване: ");
                    y = GetNumber("Введіть від'ємник: ");

                    Console.WriteLine($"Результат: {x - y}");

                    break;

                case "*":
                    x = GetNumber("Введіть перший множник: ");
                    y = GetNumber("Введіть другий множник: ");

                    Console.WriteLine($"Результат: {x * y}");

                    break;

                case "/":
                    x = GetNumber("Введіть ділене: ");
                    y = GetNumber("Введіть дільник (дільник не має дорівнювати 0): ");

                    if (y != 0)
                        Console.WriteLine($"Результат: {x / y}");
                    else
                        Console.WriteLine("Дільник не має дорівнювати 0!");

                    break;

                case "pow":
                    x = GetNumber("Число, яке потрібно піднести до степеня: ");
                    y = GetNumber("Значення степеня: ");

                    double result = Math.Pow(x, y);

                    if (result == double.PositiveInfinity || result == double.NegativeInfinity)
                        Console.WriteLine("Занадто велике число!");
                    else
                        Console.WriteLine($"Результат: {result}");

                    break;

                case "sqrt":
                    x = GetNumber("Число, для якого потрібно обчислити квадратний корінь: ");

                    if (x < 0)
                        Console.WriteLine("Квадратний корінь із негативного числа не обчислюється");
                    else
                        Console.WriteLine($"Результат: {Math.Sqrt(x)}");

                    break;

                default:
                    Console.WriteLine("Потрібно ввести одну з операцій: +, -, *, /, pow, sqrt");

                    break;

            }
        }

        private static double GetNumber(string text)
        {
            Console.WriteLine(text);

            while (true)
            {
                string number = Console.ReadLine();

                double result;

                if (Double.TryParse(number, out result))
                    return result;
                else
                    Console.WriteLine("Невірний формат. Введіть число: ");
            }
        }

        private static bool ContinueСalculation()
        {
            while (true)
            {
                Console.WriteLine("Продовжити? Так - введіть \"y\", Ні - введіть \"n\"");

                var choice = Console.ReadLine();

                if (choice == "y" || choice == "Y")
                    return true;
                else if (choice == "n" || choice == "N")
                    return false;
                else
                    Console.WriteLine("Потрібно ввести \"y\" або \"n\"");
            }
        }
    }
}
