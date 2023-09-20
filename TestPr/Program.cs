using System.Security.Cryptography;
using TestPr;
class U
{
    public string Name { get; set; }
}

class Test
{
    static void Main()
    {
        U a = new U() { Name = "A" };
        U b = new U() { Name = "B" };
        b = a;
        a.Name = "F";
        Console.WriteLine(b.Name);

        b = a;

        string a1 = "A";//new 
        string b1 = "B";
        b1 = a1;
        a1 = "F";

        a = new U() { Name = "F" };

        //Console.WriteLine(b.Name);
        Console.WriteLine(b1);

        Country country1 = new Country();
        Country country2 = new Country();
        Country country3 = new Country();
        country2.x = 1;
        country1 = country2;
        country2.x = 7;
        //country3 = null;
        //Console.WriteLine(country1.x);
    }
}

