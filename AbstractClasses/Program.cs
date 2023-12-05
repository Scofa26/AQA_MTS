using AbstractClasses.Game;

public class Program
{
    public static void Main(string[] args)
    {
        Warrior warrior = new Warrior(1);
        Wizard wizard = new Wizard(2);

        warrior.name = "sf";
        warrior.level = 1;

        warrior.Move();
        warrior.Attack();
        warrior.UseAbility();

        warrior.PrintInfo();

        Character[] characters = new Character[3];

        characters[0] = new Warrior(3);
        characters[1] = new Warrior(3);
        characters[2] = new Wizard(10);

        foreach (Character c in characters)
        {
            c.Move();
            c.PrintInfo();
        }
    }
}