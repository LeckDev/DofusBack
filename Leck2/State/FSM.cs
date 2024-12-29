using System.Transactions;

namespace Leck2.State
{
    // The main FSM class
    public class FSM
    {
        private IState _currentState;
        private readonly Dictionary<State, IState> _states;

        public FSM()
        {
            _states = new Dictionary<State, IState>
            {
                { State.Pending, new PendingState() },
                { State.Sold, new SoldState() },
                { State.Canceled, new CanceledState() }
            };

            // Set initial state
            TransitionTo(State.Pending);
        }

        public void TransitionTo(State newState)
        {
            _currentState?.Exit();
            _currentState = _states[newState];
            _currentState.Enter();
        }

        public void Update()
        {
            _currentState?.Execute();
        }
    }
}
