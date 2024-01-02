using implicit_explicit_operators.Entities;
using implicit_explicit_operators.Shared;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Usuário");
Console.WriteLine("-------");

User userPeterParker = new("Peter.Parker", 17, "peter.parker@marvel.com");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Nome: { userPeterParker.Name }, Idade: { userPeterParker.Age }, E-mail: { userPeterParker.Email }");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Implicit Operator - Customer = User");
Console.WriteLine("-----------------------------------");

Customer customerPeterParker = userPeterParker;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Nome: { customerPeterParker.Name }, Idade: { customerPeterParker.Age }");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Explicit Operator - User = (User)Customer");
Console.WriteLine("-----------------------------------------");

User userPeterParkerHero = (User)customerPeterParker;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Nome: { userPeterParkerHero.Name }, Idade: { userPeterParkerHero.Age }, E-mail: { userPeterParkerHero.Email }");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Quilômetro");
Console.WriteLine("----------");

Kilometers distanceInKm = new(5.0);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Valor: { distanceInKm.Value }");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Implicit Operator - Meters = Kilometers");
Console.WriteLine("---------------------------------------");

Meters distanceInMeters = distanceInKm;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Valor: { distanceInMeters.Value }");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Explicit Operator - Kilometers = (Kilometers)Meters");
Console.WriteLine("---------------------------------------------------");

Meters distanceInMetersE = new(5000);
Kilometers distanceInKmE = (Kilometers)distanceInMetersE;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Valor: { distanceInKmE.Value }");