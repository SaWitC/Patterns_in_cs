using System.Threading.Channels;
//Main
Car car = new Car();
HorseToTransportAdapter horse = new HorseToTransportAdapter();


Human human = new Human();
human.Travel(car);
human.Travel(horse);


//transport
public interface Itransport
{
    public void Drive();
}


public class Car :Itransport
{
    public void Drive()
    {
        Console.WriteLine("the car is comming");
    }
}
//adapte
public interface IAnimal
{
    public void Move();
}

public class Horse:IAnimal
{
    public void Move()
    {
        Console.WriteLine("the horse is comming");
    }
}
//adapter
public class HorseToTransportAdapter:Itransport
{
    Horse horse =new Horse();
    public void Drive()
    {
        horse.Move();
    }
}

//additional classes

public class Human
{
    public void Travel(Itransport transport)
    {
        transport.Drive();
    }
}