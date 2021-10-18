using System;
using DesignPatterns.Strategy.V1.NavigationStrategy;

namespace DesignPatterns.Strategy.V1
{
    class Program
    {
        // This will simulate a generation of routes on a map
        // from an origin to a destination.
        // Based on the user transportation of choice,
        // a different strategy will be used.
        private static void Main()
        {
            var origin = GetOrigin();   
            var destination = GetDestination();
            var strategyType = GetStrategyType();

            Client client = new();
            client.CallOneStrategy(strategyType, origin, destination);
        }

        private static string GetOrigin()
        {
            Console.WriteLine("Choose an origin: \n");
            return  Console.ReadLine();
        }

        private static string GetDestination()
        {
            Console.WriteLine("Choose a destination: \n");
            return Console.ReadLine();
        }

        private static StrategyCollection GetStrategyType()
        {
            Console.WriteLine(@"Choose a transportation method:
0 - Air
1 - Private
2 - Public
3 - Walk
");

            var choice = Convert.ToInt32(Console.ReadLine());
            return (StrategyCollection)choice;
        }

    }
}
