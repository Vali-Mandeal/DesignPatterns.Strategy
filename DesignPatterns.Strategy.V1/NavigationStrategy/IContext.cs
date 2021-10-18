namespace DesignPatterns.Strategy.V1.NavigationStrategy
{
    public interface IContext
    {
        void SetStrategy(IStrategy strategy);
        void ExecuteStrategy(string origin, string destination);
    }
}
