using Memory;


int a = 5;
int b = 5;
string s1 = "s";
string s2 = "s";
Car car = new Car("blue");
object car2 = car;

Console.WriteLine(MemoryAddress.Get(a));
Console.WriteLine(MemoryAddress.Get(b));
Console.WriteLine(MemoryAddress.Get(s1));
Console.WriteLine(MemoryAddress.Get(s2));
Console.WriteLine(MemoryAddress.Get(car));
Console.WriteLine(MemoryAddress.Get(car2));
Console.WriteLine(MemoryAddress.Get(ref car2));
Console.WriteLine(MemoryAddress.Get(car));
