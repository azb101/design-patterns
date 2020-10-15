namespace FlyWeight.Canonical
{
    public class UnsharedConcreteFlyweight : Flyweight
    {
        // some state properties

        public override void Operation(int extrinsicState)
        {
            System.Console.WriteLine(nameof(UnsharedConcreteFlyweight) + " operation() ");
        }
    }
}