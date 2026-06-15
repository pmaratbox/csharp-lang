using Stateless;

// Turnstile: locked --coin--> unlocked --push--> locked.
var sm = new StateMachine<string, string>("locked");
sm.Configure("locked").Permit("coin", "unlocked");
sm.Configure("unlocked").Permit("push", "locked");

// Ignore any event that has no transition from the current state,
// leaving the machine where it is instead of throwing.
sm.OnUnhandledTrigger((_, _) => { });

// 'push' has NO transition from locked: the machine stays in locked.
sm.Fire("push");

Console.WriteLine(sm.State.ToLower());
