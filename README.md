# DesignPatterns.Strategy
This is a demonstration from my DesignPattern series.

The supposed application simulates generation on different map routes, using different transportation methods.
Each transportation method (ex walk, air etc.) uses a different strategy.

V1 is the classical Strategy implementation.
V2 gets rid of the switch in Client, by implementing an identification method in each strategy. 
In response, the client will be querying the strategy collection, and choses the one who matches the enum.
