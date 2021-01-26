using System;
using System.Linq;
using static System.Console;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeType = Employee.GetEmployeeType();
            int numOfMeals = Employee.GetMealData();
            Employee.CalculateCafeteriaDues(numOfMeals, employeeType);
        }
    }

    static class Employee 
    {
        public static string GetEmployeeType()
        {
            string type = "";
            int parsedType;

            while (!Int32.TryParse(type, out parsedType) || !Enumerable.Range(1, 3).Contains(parsedType))
            {
                WriteLine("Enter the number that corresponds to the employee type: \n1. Temp\n2. Full Time\n3. Part Time");
                type = ReadLine();
            }

            switch (parsedType)
            {
                case 1:
                    return "temp";
                case 2:
                    return "fullTime";
                case 3:
                    return "partTime";
                default:
                    return "error getting data.";
            }
        }

        public static int GetMealData()
        {
            string numOfMeals = "";
            int parsedNumOfMeals;

            while (!Int32.TryParse(numOfMeals, out parsedNumOfMeals))
            {
                WriteLine("Enter the number of meals being purchased");
                numOfMeals = ReadLine();
            }
            return parsedNumOfMeals;
        }

        public static void CalculateCafeteriaDues(int numOfMeals, string employeeType)
        {
           switch (employeeType)
            {
                case "temp":
                    WriteLine($"You owe ${2.75 * numOfMeals}");
                    break;
                case "fullTime":
                    WriteLine("You get free meals, keep up the good work!");
                    break;
                case "partTime":
                    WriteLine($"You owe ${1.5 * numOfMeals}");
                    break;
            }
        }
    }
}
