using System;
using System.Collections.Generic;

class Bomb : Item
{
    public int Damage { get; }
    public Bomb(int damage = 80) : base("Bomb") { Damage = damage; }
 
    public override void Use()
        => Console.WriteLine($"[{Name}] Dilempar! BOOM! Musuh di area terkena {Damage} damage.");
}