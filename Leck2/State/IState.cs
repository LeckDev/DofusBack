namespace Leck2.State
{
    // Interface for all state behaviors
    public interface IState
    {
        void Enter();
        void Execute();
        void Exit();
    }
}
