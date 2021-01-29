using System;
using System.Xml;
using Microsoft.VisualBasic;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            var divider = new string('-', 20);

            // homework 1
            // 1
            Console.Write("Enter width: ");
            double.TryParse(Console.ReadLine(), out var width);
            Console.Write("Enter height: ");
            double.TryParse(Console.ReadLine(), out var height);
            var rectangle = new Rectangle(width, height);
            Console.WriteLine($"Area: {rectangle.Area}");
            Console.WriteLine($"Perimeter: {rectangle.Perimeter}");

            Console.WriteLine(divider);

            // 2
            var book = new Book("404", "John Doe", "Not Found");
            book.Show();

            Console.WriteLine(divider);

            // 3
            var trafficLight = new TrafficLight();
            Console.Write("Traffic is ");
            trafficLight.PrintCurrentColor();
            trafficLight.SetCurrentColor(TrafficLight.Color.Green);
            Console.Write("\nTraffic is ");
            trafficLight.PrintCurrentColor();
            trafficLight.SetCurrentColor(TrafficLight.Color.Red);
            if (trafficLight.IsRed)
            {
                Console.Write("\nPlease wait for a while, traffic is ");
                trafficLight.PrintCurrentColor();
            }

            Console.WriteLine();

            Console.WriteLine(divider);

            // homework 2
            // 1
            var converter = new Converter(0.10, 0.12, 14);
            Console.WriteLine(converter.TjsToUsd(10));

            Console.WriteLine(divider);

            // 2
            var employee = new Employee("John", "Doe") {Position = Employee.Positions.Junior2, Experience = 1};
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Surname: {employee.Surname}");
            Console.WriteLine($"Position: {employee.Position}");
            Console.WriteLine($"Salary: ${employee.GetSalary()}");
            Console.WriteLine($"Taxes: ${employee.GetTaxes()}");
        }
    }
}