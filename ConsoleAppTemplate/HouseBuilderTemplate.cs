using System;

namespace ConsoleAppTemplate
{
    public abstract class HouseBuilderTemplate
    {
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
        }
        protected void BuildFoundation() {
            Console.WriteLine("Foundation is the same for all houses");
        }
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
    }
}
