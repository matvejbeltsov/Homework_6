using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Task_1
{
    
    internal class Program
    {
        public static int Prompt(string message){
            Console.WriteLine(message);
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        
        }


        public static int[] InputArray(int length){
            int[] array = new int[length];

            for(int i = 0; i < array.Length; i++){
                array[i] = Prompt($"Введите {i + 1} элемент");
            }
            return array;
        }

        public static void PrintArray(int[] array){
            Console.Write(array[0]);
            for (int i = 1; i < array.Length; i++){
                Console.Write($", {array[i]}");
            }
            Console.WriteLine();
        }

        public static int CountPositiveElements(int[] array){
            int count = 0;
            for (int i = 0; i < array.Length; i++){
                if(array[i] > 0){
                    count++;
                }
            }
            return count;
        } 
       
        static void Main(string[] args)
        {
            int length = Prompt("Введите количество элементов > ");
            int[] array;
            array = InputArray(length);
            PrintArray(array);
            Console.WriteLine("Количество положительных элементов в массиве " + CountPositiveElements(array));
            
        }
    }
}
