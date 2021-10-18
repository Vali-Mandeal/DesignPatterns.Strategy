namespace DesignPatterns.Strategy.V2.NavigationStrategy
{
    // The strategy interface declares operations common to all
    // supported versions of some algorithm. The context uses this
    // interface to call the algorithm defined by the concrete
    // strategies.
    public interface IStrategy
    {
        void Execute(string origin, string destination);
        public bool IsApplyingTo(StrategyCollection type);
    }
}
    