using System;
using System.Collections.Generic;

class ManaPotion : Item
{
    public int ManaAmount { get; }
    public ManaPotion(int manaAmount = 30) : base("Mana Potion") { ManaAmount = manaAmount; }
 
    public override void Use()
        => Console.WriteLine($"[{Name}] Diminum! Mana pemain pulih +{ManaAmount}.");
}