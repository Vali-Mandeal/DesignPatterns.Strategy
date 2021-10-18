using DesignPatterns.Strategy.V1.NavigationStrategy;
using DesignPatterns.Strategy.V1.NavigationStrategy.Concrete;

namespace DesignPatterns.Strategy.V1
{
    // Simulating a client for those strategies
    // The client code picks a concrete strategy and passes it to
    // the context. The client should be aware of the differences
    // between strategies in order to make the right choice.

    public class Client
    {
        public void CallOneStrategy(StrategyCollection type, string origin, string destination)
        {
            IContext context = new Context();

            SetStrategy(type, context);
            context.ExecuteStrategy(origin, destination);
        }

        private static void SetStrategy(StrategyCollection type, IContext context)
        {
            // for simplicity I used a switch to set different strategies
            switch (type)
            {
                case StrategyCollection.Air:
                    context.SetStrategy(new AirTransportStrategy());
                    break;
                case StrategyCollection.Private:
                    context.SetStrategy(new PrivateTransportStrategy());
                    break;
                case StrategyCollection.Public:
                    context.SetStrategy(new PublicTransportStrategy());
                    break;
                case StrategyCollection.Walk:
                    context.SetStrategy(new WalkStrategy());
                    break;
            }
        }
    }
}   
    