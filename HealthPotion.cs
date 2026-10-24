using System;
using System.Collections.Generic;

class HealthPotion : Item
{
    public int HealAmount { get; }
    public HealthPotion(int healAmount = 50) : base("Health Potion") { HealAmount = healAmount; }
 
    public override void Use()
        => Console.WriteLine($"[{Name}] Diminum! HP pemain pulih +{HealAmount}.");
}