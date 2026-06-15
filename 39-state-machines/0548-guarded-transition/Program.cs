using Stateless;

// Door FSM with the Stateless library.
// The "open" event is ONLY a valid transition out of "unlocked":
// it is defined exclusively on the unlocked state, so firing it from
// any other state would be rejected by the machine.
var sm = new StateMachine<string, string>("locked");

sm.Configure("locked")
  .Permit("unlock", "unlocked");

sm.Configure("unlocked")
  .Permit("open", "open");

// Fire the fixed event sequence.
sm.Fire("unlock");
sm.Fire("open");

// The resulting state comes from the machine, lowercased.
Console.WriteLine(sm.State.ToLower());
