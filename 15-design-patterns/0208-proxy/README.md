# 0208 — Virtual Proxy

Use a lazy virtual proxy that loads the real subject only on first access, printing `loaded`. A null-conditional `??=` assignment creates the real subject the first time `Request()` is called.

## Run

    dotnet run
