
using MemoryAddress;
Car car = new Car("blue");

Console.WriteLine(MemoryAddress.MemoryAddress.Get(car));
Console.WriteLine((new Car("blue")).GetHashCode());