using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskPowerLine
{
  class SportCar : Car
  {
    public SportCar(float _avg, float _capacity, float _vel)
    {
      this._type = CarType.SportCar;
      this._avgFuelConsumption = _avg;
      this._fuelTankCapacity = _capacity;
      this._velocity = _vel;
    }
  }
}
