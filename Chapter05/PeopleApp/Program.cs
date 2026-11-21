using Packt.Shared;
ConfigureConsole();

Person Bob = new Person();
Bob.Name = "Bob Smith";
Bob.Born = new DateTimeOffset(

    year: 1965, month: 12, day: 22, hour: 16, minute: 28, second: 0, offset: TimeSpan.FromHours(-5)

);
Person Alfie = new Person();
Alfie.Name = "Alfie";
Person Zoe = new Person();
Zoe.Name = "Zoe";
Bob.Children.Add(Alfie);
Bob.Children.Add(Zoe);

WriteLine($"{Bob.Name} was born on {Bob.Born}, Bob's children are {Bob.Children[1].Name} and {Bob.Children[0].Name} ");


int a = 10;
int b = 20;
int c  = 30;
int d = 40;


WriteLine($"Before: a = {a}, b = {b}, c = {c}, d = {d}");
Bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a = {a}, b = {b}, c = {c}, d = {d}");

Bob.ParamsParameters("Sum using commas", 1,2,3,4);


(string, int) fruit = Bob.GetFruit();
