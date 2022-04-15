using System;

namespace ConsoleAppTemplate
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Build a Concrete House");
            HouseBuilderTemplate houseTemplate = new ConcreteHouse();
            
            // call the template method
            houseTemplate.BuildHouse();
            Console.WriteLine();
            Console.WriteLine("Build a Wooden House\n");

            houseTemplate = new WoodHouse();

            // call the template method
            houseTemplate.BuildHouse();
            Console.ReadLine();
        }
    }
}
