namespace FlyWeight.Canonical
{
    public class ConcreteFlyweightA : Flyweight
    {
        // some state properties

        public override void Operation(int extrinsicState)
        {
            System.Console.WriteLine(nameof(ConcreteFlyweightA) + " operation() ");
        }
    }
}