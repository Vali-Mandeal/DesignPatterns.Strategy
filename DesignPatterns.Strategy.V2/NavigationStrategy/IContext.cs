namespace DesignPatterns.Strategy.V2.NavigationStrategy
{
    public interface IContext
    {
        void SetStrategy(IStrategy strategy);
        void ExecuteStrategy(string origin, string destination);
    }
}
