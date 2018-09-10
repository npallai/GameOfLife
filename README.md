# GameOfLife
Conway's Game of Life

This current version allows moving across the Universe with the arrow keys.
It uses a Dictionary which is an implementation of the generic hash table in C# to store living cells only. As a result the iterations will get slower when the number of living cells increase over time. In this version the calculations and iteration over the Dictionary of living cells is done on a Timer. Timer executes on an interval. It uses a single background thread off of the UI background thread to allow interaction with the UI elements in a thread safe manner. This is not the ideal threading plan for this application. In the next iteration this timer thread should be replaced with it's own isolated thread instead of a Timer. The timer executes a callback on a schedule. If calculations are not completed before the next tick there will be a collision. Instead this calculation should be done on an isolated thread that only executes the next tick after the current calculation cycle is completed.

Another change that can be made later on is storing hashes of patterns to avoid recalculating recurring patterns for the instances of stable lifeforms like the block.
