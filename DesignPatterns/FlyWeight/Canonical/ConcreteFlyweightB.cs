namespace FlyWeight.Canonical
{
    public class ConcreteFlyweightB : Flyweight
    {
        // some state properties

        public override void Operation(int extrinsicState)
        {
            System.Console.WriteLine(nameof(ConcreteFlyweightB) + " operation() ");
        }
    }
}