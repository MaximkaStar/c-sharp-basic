using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {
        static int age;
        static string name;
        static bool isAdult = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст:");
            age = int.Parse(Console.ReadLine());

            var number = "";
            dynamic data;

            int firstNumber = 5;
            long secondNumber = firstNumber;


            long thirdNumber = 5;
            int fourthNumber = (int)thirdNumber;

            switch (5*8)
            {
                case 30:
                    // Какой-то код
                    break;
                case 40:
                    // code
                    break;
                default:
                    //code
            }

            bool operationResult = 5 > 3;

            if(operationResult)
            {

            }
            else
            {

            }

            String data = null;

            if(data != null)
            {
                var stringResult = data.IndexOf('a');
            }

            var result = data?.IndexOf('a');

            String data2 = null;
            //Если data2 не null, то присвоим 'Ничего нет'. Иначе присвоим data2.
            var data2Resul = data2 ?? "ничего нет";

            for (i=0; i<10; i++)
            {
                // Действие а каждую итерацию
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //служит для прохода по каждому элементу.
            foreach(int numb in number)
            {
                Console.WriteLine(numb);
            }
        }
    }
}
