using System.Security.AccessControl;

theKnight Knight = new theKnight();
theMonster Monster = new theMonster();

Console.WriteLine("what is your name");
Knight.name = Console.ReadLine();
Console.WriteLine("what is youre enemys name");
Monster.name = Console.ReadLine();

while(Knight.health > 0 && Monster.health > 0)
{

    int kdmg = Random.Shared.Next(Knight.damage);
    int mdmg = Random.Shared.Next(Monster.damage);

Console.WriteLine($"{Knight.name} has {Knight.health} health");
Console.WriteLine($"{Monster.name} has {Monster.health} health");

Console.WriteLine("Attack");
Console.ReadLine();
Monster.health -= kdmg;
Knight.health -= mdmg;
    }

if (Knight.health <= 0 && Monster.health <= 0)
{
    Console.WriteLine("Both died wow");

} 
else if (Monster.health <= 0)
{
    Console.WriteLine("Knight wins");
}
else if (Knight.health <= 0)
{
    Console.WriteLine("Monster wins");
}
Console.ReadLine();


