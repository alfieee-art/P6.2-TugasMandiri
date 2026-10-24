using System;
using System.Collections.Generic;

class PowerUp : ICollectible
{
    public string Effect { get; }
    public PowerUp(string effect = "Speed Boost") { Effect = effect; }
 
    public void Collect()
        => Console.WriteLine($"Power-up diambil! Efek aktif: {Effect} selama 10 detik.");
}