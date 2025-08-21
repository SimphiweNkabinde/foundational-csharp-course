Random attack = new Random();
int heroHealth = 10;
int monsterHealth = 10;

while (heroHealth > 0 && monsterHealth > 0)
{
    int damage = attack.Next(1, 11);

    monsterHealth -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");

    if (monsterHealth <= 0) continue;

    heroHealth -= damage;
    Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
}

Console.WriteLine(heroHealth > monsterHealth ? "Hero Wins!" : "Monster Wins!");
