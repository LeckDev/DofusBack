namespace Leck2.State
{
    // Concrete implementation of the Sold state
    public class SoldState : IState
    {
        public void Enter() => Console.WriteLine("Entering Sold state.");

        public void Execute() => Console.WriteLine("Bundle/Transaction is completed and sold.");

        public void Exit() => Console.WriteLine("Exiting Sold state.");
    }
}
