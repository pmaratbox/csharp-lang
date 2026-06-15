using Stateless;

// A four-state ring: a -> b -> c -> d, driven by the "next" trigger.
var sm = new StateMachine<string, string>("a");
sm.Configure("a").Permit("next", "b");
sm.Configure("b").Permit("next", "c");
sm.Configure("c").Permit("next", "d");

// Per-transition action: increment a counter on EACH transition the machine performs.
var count = 0;
sm.OnTransitioned(_ => count++);

// Fire a fixed sequence of 3 valid events.
sm.Fire("next");
sm.Fire("next");
sm.Fire("next");

// The count comes from the per-transition callback, not a hardcoded value.
Console.WriteLine(count);
