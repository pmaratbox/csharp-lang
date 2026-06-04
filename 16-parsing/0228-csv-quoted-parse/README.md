# 0228 — Parse Quoted CSV

Parse the CSV row `a,"b,c",d`, respecting the quoted comma, into three fields joined by pipes `a|b,c|d`. A single pass tracks an in-quotes flag so the embedded comma is not treated as a separator.

## Run

    dotnet run
