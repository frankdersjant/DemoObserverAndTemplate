using System;

namespace ConsoleAppTemplate
{
    public class ConcreteHouse : HouseBuilderTemplate
    {
        protected override void BuildPillars()
        {
            Console.WriteLine("Building Pillars with Cement and Sand");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Building Walls");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Building Windows");
        }
    }
}
