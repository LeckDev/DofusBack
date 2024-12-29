namespace Leck2.State
{
    // Concrete implementation of the Canceled state
    public class CanceledState : IState
    {
        public void Enter() => Console.WriteLine("Entering Canceled state.");

        public void Execute() => Console.WriteLine("Bundle/Transaction has been canceled.");

        public void Exit() => Console.WriteLine("Exiting Canceled state.");
    }
}
