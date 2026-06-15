using Stateless;

// Turnstile FSM with two states. The machine starts "locked".
var sm = new StateMachine<string, string>("locked");
sm.Configure("locked").Permit("coin", "unlocked");
sm.Configure("unlocked").Permit("push", "locked");

// Fire the fixed event sequence; the machine decides the resulting state.
sm.Fire("coin");

// Print the state name lowercased (comes from the machine, not hardcoded).
Console.WriteLine(sm.State.ToLower());
