namespace VorobevEvgenyConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            int resultValue = GetSum(12, 12);
            Console.WriteLine(resultValue);
        }

        static int GetSum(int firstValue, int secondValue) {
            return firstValue + secondValue;
        }
    }
}

//ничего не принимает
//ничего не возвращает
//внутри есть переменная которая увеличиваеться на 1
