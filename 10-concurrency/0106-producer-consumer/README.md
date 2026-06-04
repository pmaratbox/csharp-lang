# 0106 — Producer / Consumer

A producer sends 1..5 to a consumer that sums them, printing `15`. A bounded `Channel` applies backpressure while the consumer accumulates the running total.

## Run

    dotnet run
