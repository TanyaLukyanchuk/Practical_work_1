using System;
namespace PW1
{
    class program
    {
        public static double CalculateTime(double distance, double speed)
        {
            return (distance / speed) * 60;
        }
        static void Main()
        {
            double Speed1; double Speed2; double Speed3; double Speed4;
            string Name1; string Name2; string Name3; string Name4;

            Cars car1 = new Cars("Rimac Concept Two", 415);
            Speed1 = car1.Speed;
            Name1 = car1.Car;
            car1.DataCar();
            Cars car2 = new Cars("McLaren Speedtails");
            car2.Speed = 402;
            Speed2 = car2.Speed;
            Name2 = car2.Car;
            car2.DataCar();
            Cars car3 = new Cars("Hennessey Venom F5", 484);
            Speed3 = car3.Speed;
            Name3 = car3.Car;
            car3.DataCar();
            Cars car4 = new Cars("Koenigsegg Regeraчник");
            car4.Speed = 410;
            Speed4 = car4.Speed;
            Name4 = car4.Car;
            car4.DataCar();

            double distance = 500;

            double Time1; double Time2; double Time3; double Time4;
            Time1 = CalculateTime(distance, Speed1);
            Time2 = CalculateTime(distance, Speed2);
            Time3 = CalculateTime(distance, Speed3);
            Time4 = CalculateTime(distance, Speed4);

            string Name; double Speed; double Time;
            if (Time1 < Time2) { Time = Time1; Name = Name1; Speed = Speed1; }
            else { Time = Time2; Name = Name2; Speed = Speed2; }
            if (Time > Time3) { Time = Time3; Name = Name3; Speed = Speed3; }
            if (Time > Time4) { Time = Time4; Name = Name4; Speed = Speed4; }

            Console.WriteLine("\nНазвание машины-победителя: {0}\nМаксимальная скорость машины: {1} км/ч\nВремя преодоления пути: {2} минут\n", Name, Speed, Time);
        }
    }

    class Cars
    {
        public string Car;
        public double Speed;

        public Cars(string car)
        {
            this.Car = car;
        }
        public Cars(string car, double Speed)
        {
            this.Car = car;
            this.Speed = Speed;
        }
        public void DataCar()
        {
            Console.WriteLine("Название машины: {0}\nСкорость: {1} км/ч\n", Car, Speed);
        }
    }
}