namespace FlyWeight.Canonical
{
    public class ConcreteFlyweightC : Flyweight
    {
        // some state properties

        public override void Operation(int extrinsicState)
        {
            System.Console.WriteLine(nameof(ConcreteFlyweightC) + " operation() ");
        }
    }
}