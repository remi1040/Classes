using Classes;

class Program
{
    public static void Main(string[] args)
    {
        Character perso1 = new Character("toto", 40, 20, 30);
        Character perso2 = new Character("titi", 50, 100, 15);

        perso1.Attack(perso2);
        perso2.Attack(perso1);

        Console.WriteLine(" Pv perso 1 : " + perso1.pv);
        Console.WriteLine(" Pv perso 2 : " + perso2.pv);

        Console.WriteLine($"Le personnage 1 est toujours en vie : {perso1.IsAlive()}");
    }
}