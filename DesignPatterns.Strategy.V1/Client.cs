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
        public void CallOneStrategy(StrategyTypes types, string origin, string destination)
        {
            IContext context = new Context();

            SetStrategy(types, context);
            context.ExecuteStrategy(origin, destination);
        }

        private static void SetStrategy(StrategyTypes types, IContext context)
        {
            // for simplicity I used a switch to set different strategies
            switch (types)
            {
                case StrategyTypes.Air:
                    context.SetStrategy(new AirTransportStrategy());
                    break;
                case StrategyTypes.Private:
                    context.SetStrategy(new PrivateTransportStrategy());
                    break;
                case StrategyTypes.Public:
                    context.SetStrategy(new PublicTransportStrategy());
                    break;
                case StrategyTypes.Walk:
                    context.SetStrategy(new WalkStrategy());
                    break;
            }
        }
    }
}   
    