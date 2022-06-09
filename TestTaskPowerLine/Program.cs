
using TestTaskPowerLine;

Random _rand = new Random();

LightCar lCar = new LightCar(_rand.Next(10, 21), _rand.Next(40, 61), _rand.Next(0, 5), _rand.Next(40, 121));
CargoCar cCar = new CargoCar(_rand.Next(15, 31), _rand.Next(80, 121), _rand.Next(0, 2001), _rand.Next(30, 101));
SportCar sCar = new SportCar(_rand.Next(5, 16), _rand.Next(30, 51), _rand.Next(80, 151));

lCar.ShowCar();
cCar.ShowCar();
sCar.ShowCar();

Console.ReadKey(false);
