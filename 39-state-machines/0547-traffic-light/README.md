# 0547 — Traffic light

Uses the [Stateless](https://github.com/dotnet-state-machine/stateless) finite-state-machine library. We declare three states (`red`, `green`, `yellow`) and wire each one's `next` event to the following colour with `Configure(...).Permit("next", ...)`, modelling the classic traffic-light cycle. Starting in `red`, firing `next` twice transitions `red -> green -> yellow`; the resulting `State` is read back from the machine and printed lowercased.

## Run

    dotnet run
