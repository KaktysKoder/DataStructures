using System;
using SinglyLinkedList.Model;

namespace SinglyLinkedList
{
    internal sealed class StartProgram
    {
        private static void Main()
        {
            FunctionalityCheck();
        }

        private static void FunctionalityCheck()
        {
            try
            {
                TitleMessage("Создание целочисленного списка числе 10, 20, ..., 90, 100.");

                LinkedList<int> numList = new LinkedList<int>()
                {
                    10, 20, 30, 40, 50, 60, 70, 80, 90, 100
                };

                Console.WriteLine($"-> Колличество элементов в списке = {numList.Count}.\n");
                Console.Write("-> Содержимое списка:");

                ForEach(numList);
                TitleMessage("Удаление из списка чисел 10, 20, 30.");

                numList.Delete(10);
                numList.Delete(20);
                numList.Delete(30);

                Console.WriteLine($"-> Колличество элементов в списке после удаления трёх чисел: {numList.Count}.\n");
                Console.Write("-> Содержимое списка после удаления трёх чисел: ");

                ForEach(numList);
                TitleMessage("Добавить число 90 в начало списка.");

                numList.AppendHead(90);

                Console.Write("-> Содержимое списка после добавления числа в начало: ");

                ForEach(numList);
                TitleMessage("Вставка числа 1000, после числа 80.");

                numList.InsertAfter(80, 1000);

                Console.Write("-> Содержимое списка, после вставки числа 1000, которое вставляют после числа 80: ");

                ForEach(numList);
                TitleMessage("Полная очистка списка!");

                numList.Clear();

                Console.Write("-> Содержимое списка после его очистки: ");

                ForEach(numList);
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine($"Message:    ---> {exc.Message}   ");
                Console.WriteLine($"StackTrace: ---> {exc.StackTrace}");
                Console.WriteLine($"TargetSite: ---> {exc.TargetSite}");
            }
            catch (ArgumentNullException exc)
            {
                Console.WriteLine($"Message:    ---> {exc.Message}   ");
                Console.WriteLine($"StackTrace: ---> {exc.StackTrace}");
                Console.WriteLine($"TargetSite: ---> {exc.TargetSite}");
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Message:    ---> {exc.Message}   ");
                Console.WriteLine($"StackTrace: ---> {exc.StackTrace}");
                Console.WriteLine($"TargetSite: ---> {exc.TargetSite}");
            }
        }

        /// <summary>
        /// Метод для минимизации повторяющегося кода; 
        /// Метод содержит: foreach (int item in instance)
        /// </summary>
        private static void ForEach(LinkedList<int> instance)
        {
            foreach (int item in instance)
            {
                Console.Write($" {item} ");
            }

            Console.WriteLine("\n");
        }

        /// <summary>
        /// Метод для минимизации повторяющегося кода; 
        /// Вывод сообщения в определенном формате.
        /// </summary>
        private static void TitleMessage(string message)
        {
            Console.WriteLine("=====================================================================");
            Console.WriteLine($"{message}");
            Console.WriteLine("=====================================================================\n");
        }

    }
}
