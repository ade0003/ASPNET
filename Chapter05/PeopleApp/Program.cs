using Packt.Shared;
ConfigureConsole();

Person Bob = new Person();
Bob.Name = "Bob Smith";
Bob.Born = new DateTimeOffset(

    year: 1965, month: 12, day: 22, hour: 16, minute: 28, second: 0, offset: TimeSpan.FromHours(-5)

);

WriteLine($"{Bob.Name} was born on {Bob.Born}");