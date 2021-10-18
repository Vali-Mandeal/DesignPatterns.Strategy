using System;

namespace DesignPatterns.Strategy.V2.NavigationStrategy.Concrete
{
    // Concrete strategies implement the algorithm while following
    // the base strategy interface. The interface makes them
    // interchangeable in the context.
    public class WalkStrategy : IStrategy
    {
        public void Execute(string origin, string destination)
        {
            Console.WriteLine($"Generated a walk strategy from point {origin} to {destination}");
        }

        public bool IsApplyingTo(StrategyCollection type)
        {
            return type == StrategyCollection.Walk;
        }
    }
}
