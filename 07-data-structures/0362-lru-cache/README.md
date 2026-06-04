# 0362 — LRU Cache

With a capacity-2 LRU cache: put(1,1),put(2,2),get(1),put(3,3) evicts key 2; then get(1)=1 and get(2)=-1, printing `1 -1`. A `Dictionary` plus `LinkedList` gives O(1) lookup with explicit recency ordering.

## Run

    dotnet run
