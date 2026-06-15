using Stateless;

// Traffic light as a finite state machine: red -> green -> yellow -> red,
// each step driven by the "next" event.
var light = new StateMachine<string, string>("red");

light.Configure("red").Permit("next", "green");
light.Configure("green").Permit("next", "yellow");
light.Configure("yellow").Permit("next", "red");

// Fire the fixed event sequence: red -> green -> yellow.
light.Fire("next");
light.Fire("next");

Console.WriteLine(light.State.ToLower());
