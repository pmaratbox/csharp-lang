using Stateless;

var sm = new StateMachine<string, string>("off");
sm.Configure("off").Permit("toggle", "on");
sm.Configure("on").Permit("toggle", "off");

sm.Fire("toggle");
sm.Fire("toggle");
sm.Fire("toggle");

Console.WriteLine(sm.State.ToLower());
