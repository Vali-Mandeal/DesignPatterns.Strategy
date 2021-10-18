using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Strategy.V2.NavigationStrategy;
using DesignPatterns.Strategy.V2.NavigationStrategy.Concrete;

namespace DesignPatterns.Strategy.V2
{
    // Simulating a client for those strategies
    // The client code picks a concrete strategy and passes it to
    // the context. The client should be aware of the differences
    // between strategies in order to make the right choice.

    public class Client
    {
        private readonly List<IStrategy> _strategies;

        public Client()
        {
            // Normally I'd use DI
            _strategies = new List<IStrategy>
            {
                new AirTransportStrategy(),
                new PrivateTransportStrategy(),
                new PublicTransportStrategy(),
                new WalkStrategy()
            };
        }
        public void CallOneStrategy(StrategyCollection type, string origin, string destination)
        {
            IContext context = new Context();

            context.SetStrategy(_strategies.First(st => st.IsApplyingTo(type)));
            context.ExecuteStrategy(origin, destination);
        }
    }
}   
    