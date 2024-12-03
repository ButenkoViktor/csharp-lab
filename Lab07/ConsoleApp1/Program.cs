
using ConsoleApp1;

Animal animal = new Dog();
Console.WriteLine(animal.Sound);
animal.Move();
animal.FetchBall();

Dog dog = new Dog();
Console.WriteLine(dog.Sound);
dog.Move();
dog.FetchBall();

Cat  cat = new Cat();
Console.WriteLine(cat.Move);
Console.WriteLine(cat.Sound);
Console.WriteLine(cat.ThrowOfTheTable);
cat.Move();
cat.ThrowOfTheTable();
