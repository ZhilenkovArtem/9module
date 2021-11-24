using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9module
{
    public delegate void Notify(List<string> surnames);
    class Task2
    {
        public static void Main()
        {
            var surnames = new List<string>
            {
                "Иванов", "Петров", "Сидоров", "Беков", "Меков"
            };
            while (true)
            {
                Console.WriteLine("Введите число:");
                ProcessBusinessLogic bl = new ProcessBusinessLogic();
                bl.ProcessCompleted += Show;
                try
                {
                    bl.StartProcess(surnames);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Вы ввели не число");
                }
                catch (Not1and2Exception)
                {
                    Console.WriteLine("Число должно быть 1 или 2");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
        public static void Show(List<string> surnames)
        {
            foreach (var sn in surnames)
            {
                Console.WriteLine(sn);
            }
        }
    }
    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted;
        public void StartProcess(List<string> surnames)
        {
            bool stringIsNumber = int.TryParse(Console.ReadLine(), out int number);
            if (!stringIsNumber) throw new ArgumentNullException();
            if (number == 1)
            {
                surnames.Sort();
            }
            else if (number == 2)
            {
                surnames.Sort();
                surnames.Reverse();
            }
            else throw new Not1and2Exception();

            OnProcessCompleted(surnames);
        }
        protected virtual void OnProcessCompleted(List<string> surnames)
        {
            ProcessCompleted?.Invoke(surnames);
        }
    }
    public class Not1and2Exception : Exception { }
}