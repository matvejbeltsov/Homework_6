using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Task_2
{
    
    internal class Program
    {
        const int COEFFICIENT = 0;
        const int CONSTANTS = 1;
        const int X_COORD = 0;
        const int Y_COORD = 1;
         const int Line1 = 1;
        const int Line2 = 2;
        
        public static double[] InputLineData(int numberOfLine){
            double[] linedata = new double[2];
            linedata[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой > ");
            linedata[CONSTANTS] = Prompt($"Введите константу для {numberOfLine} прямой > ");
            return linedata;
        }
        
        
        public static int Prompt(string message){
            Console.WriteLine(message);
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        
        }

        public static double[] FindCoords(double[] lineData1, double[] lineData2){
            double[] coord = new double[2];
            coord[X_COORD] = (lineData1[CONSTANTS] - lineData2[CONSTANTS]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
            coord[Y_COORD] = lineData1[CONSTANTS] * coord[X_COORD] + lineData1[CONSTANTS];
            return coord;
        }
 
        public static bool ValidateLine(double[] lineData1, double[] lineData2){
            if(lineData1[COEFFICIENT] == lineData2[COEFFICIENT]){

                if(lineData1[CONSTANTS] == lineData2[CONSTANTS]){
                    Console.WriteLine("Прямые совпадают");
                    return false;
                }

                else{
                    Console.WriteLine("Прямые параллельны");
                    return false;
                }

            }
            return true;
        }
        


        
       
        static void Main(string[] args)
        {
            

            double[] lineData1 = InputLineData(Line1);
            double[] lineData2 = InputLineData(Line2);

            if(ValidateLine(lineData1, lineData2)){
                double[] coord = FindCoords(lineData1, lineData2);
                Console.Write($"Точка пересечения уравнения y = {lineData1[COEFFICIENT]} * x + {lineData1[CONSTANTS]} и y = {lineData2[COEFFICIENT]} * x + {lineData2[CONSTANTS]}");
                Console.WriteLine($" имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
            }
            
        }
    }
}
