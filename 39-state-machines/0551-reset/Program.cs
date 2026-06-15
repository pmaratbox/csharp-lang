using Stateless;

var sm = new StateMachine<string, string>("idle");

sm.Configure("idle").Permit("start", "running");
sm.Configure("running").Permit("reset", "idle");

sm.Fire("start");
sm.Fire("reset");

Console.WriteLine(sm.State.ToLower());
