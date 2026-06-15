using Stateless;

var sm = new StateMachine<string, string>("idle");

sm.Configure("idle").Permit("submit", "pending");
sm.Configure("pending").Permit("approve", "approved");

sm.Fire("submit");
sm.Fire("approve");

Console.WriteLine(sm.State.ToLower());
