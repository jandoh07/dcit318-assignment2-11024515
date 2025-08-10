namespace dcit318_assignment2_11024515.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }

    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move() => Console.WriteLine("Car is moving");
    }

    public class Bicycle : IMovable
    {
        public void Move() => Console.WriteLine("Bicycle is moving");
    }

}
