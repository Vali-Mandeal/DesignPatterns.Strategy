namespace DesignPatterns.Strategy.V1.NavigationStrategy
{
    public class Context : IContext
    {
        // The context maintains a reference to one of the strategy
        // objects. The context doesn't know the concrete class of a
        // strategy. It should work with all strategies via the
        // strategy interface
        private IStrategy _strategy;

        // Usually the context accepts a strategy through the
        // constructor, and also provides a setter so that the
        // strategy can be switched at runtime.
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // The context delegates some work to the strategy object
        // instead of implementing multiple versions of the
        // algorithm on its own.
        public void ExecuteStrategy(string origin, string destination)
        {
            _strategy.Execute(origin, destination);
        }
    }
}
