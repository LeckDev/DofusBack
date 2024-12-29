namespace Leck2.State
{
    // Concrete implementation of the Pending state
    public class PendingState : IState
    {
        public void Enter() => Console.WriteLine("Entering Pending state.");

        public void Execute() => Console.WriteLine("Bundle/Transaction is pending.");

        public void Exit() => Console.WriteLine("Exiting Pending state.");
    }
}
