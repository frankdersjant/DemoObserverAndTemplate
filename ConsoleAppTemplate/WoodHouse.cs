using System;

namespace ConsoleAppTemplate
{
    public class WoodHouse : HouseBuilderTemplate
    {
        protected override void BuildPillars()
        {
            Console.WriteLine("Chopping wood");
        }
        protected override void BuildWalls()
        {
            Console.WriteLine("Chopping Wood");
        }
        protected override void BuildWindows()
        {
            Console.WriteLine("Chopping Wood");
        }
    }
}
