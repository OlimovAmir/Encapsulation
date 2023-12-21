using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Class1
    {
        public void MaxSum() 
        {
            // Пример массива чисел
            int[] numbers = { 50, 5, 8, 3, 7 };

            // Используем метод Max для нахождения максимального числа
            int maxNumber = numbers.Max();

            // Выводим результат
            Console.WriteLine($"Максимальное число в массиве: {maxNumber}");
        }

        public void MinSum()
        {
            int[] numbers = { 10, 25, 41, 5, 15 };
            int minNumber = numbers.Min();
            Console.WriteLine($"Минимальное число в массиве: {minNumber}");
        }

        public void Sort() 
        {
            // Пример массива чисел
            int[] numbers = { 10, 5, 8, 3, 7 };

            // Сортируем массив по возрастанию
            Array.Sort(numbers);

            // Выводим отсортированный массив
            Console.WriteLine("Отсортированный массив по возрастанию:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine(); // Переходим на новую строку
        
        }
    }
}
