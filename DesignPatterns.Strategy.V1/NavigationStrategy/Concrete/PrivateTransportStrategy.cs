using System;

namespace DesignPatterns.Strategy.V1.NavigationStrategy.Concrete
{
    // Concrete strategies implement the algorithm while following
    // the base strategy interface. The interface makes them
    // interchangeable in the context.
    public class PrivateTransportStrategy : IStrategy
    {
        public void Execute(string origin, string destination)
        {
            Console.WriteLine($"Generated a private transport strategy from point {origin} to {destination}");
        }
    }
}
