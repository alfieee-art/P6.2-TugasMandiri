using System;
using System.Collections.Generic;
 
interface ICollectible
{
    void Collect();
}
 
class Coin : ICollectible
{
    public int Value { get; }
    public Coin(int value = 10) { Value = value; }
 
    public void Collect()
        => Console.WriteLine($"Koin diambil! Skor bertambah +{Value}.");
}
