using System;

class Program
{
    static void ProcessCollectibles(List<ICollectible> items)
    {
        foreach (var item in items)
            item.Collect();
    }
 
    static void Main()
    {
        List<ICollectible> collectibles = new()
        {
            new Coin(),
            new PowerUp(),
            new Coin(25),
            new PowerUp("Double Damage")
        };
 
        ProcessCollectibles(collectibles);
    }
}
 