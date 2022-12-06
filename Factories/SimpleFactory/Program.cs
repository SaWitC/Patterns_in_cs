using SimpleFactory;
//simple factory


ISimpleFactory factory=new SimpleFactory.SimpleFactory();
var animl =factory.CreateAnimal(1);
animl.Move();

Console.WriteLine("===============================================");
//factory method
ICarFactory carFactory =new PassengerCarFactory();

var car1 =carFactory.CreateCar("B");
var car2 = carFactory.CreateCar();
car1.Start();car1.Stop();

Console.WriteLine("===============================================");
//abstract factory

IAnimalFactory animalFactory =new WildAnimalFactory();

var cat=animalFactory.CreateCat();
var dog =animalFactory.CreaDog();

dog.Move();
dog.PrefersToDo();

cat.Move();
cat.SawAMan();