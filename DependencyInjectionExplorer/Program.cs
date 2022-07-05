// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;

var collection = new ServiceCollection();
collection.AddScoped<ScopedClass>();
collection.AddTransient<TransientClass>();
collection.AddSingleton<SingletonClass>();

var builder = collection.BuildServiceProvider();

Console.Clear();

Parallel.For(1, 10, i =>
{
    Console.WriteLine($"Scoped ID = {builder.GetService<ScopedClass>().GetHashCode().ToString()}");
    Console.WriteLine($"Transient ID = {builder.GetService<TransientClass>().GetHashCode().ToString()}");
    Console.WriteLine($"Singleton ID = {builder.GetService<SingletonClass>().GetHashCode().ToString()}");
});


Console.WriteLine("Press a key");
Console.ReadKey();


public class ScopedClass
{
}

public class TransientClass
{
}

public class SingletonClass
{
}