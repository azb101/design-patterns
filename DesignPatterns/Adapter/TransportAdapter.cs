using Adapter.ImaginaryExample;

namespace Adapter
{
    public class TransportAdapter : Car
    {
        private Camel camel;

        public TransportAdapter(Camel camel)
        {
            this.camel = camel;
        }

        public override void Drive()
        {
            this.camel.Ride();
        }
    }
}