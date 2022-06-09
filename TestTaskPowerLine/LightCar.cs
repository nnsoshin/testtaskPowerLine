using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskPowerLine
{
  class LightCar : Car
  {
    protected int _passengersQuantity { get; set; }

    protected const int MaxPassengersQuantity = 4;

    protected override float CalculateAvailableDistance(float _fuelTankFullness)
    {
      if (_fuelTankFullness <= 0 ||
        _fuelTankFullness > this._fuelTankCapacity ||
        this._passengersQuantity < 0 ||
        this._passengersQuantity > MaxPassengersQuantity)
      {
        return 0;
      }

      float _distanceMultiplier = 1 - (this._passengersQuantity * 6) / 100;

      return base.CalculateAvailableDistance(_fuelTankFullness) * _distanceMultiplier;
    }

    public LightCar(float _avg, float _cap, int _pass, float _vel)
    {
      this._type = CarType.LightCar;
      this._avgFuelConsumption = _avg;
      this._fuelTankCapacity = _cap;
      this._passengersQuantity = _pass;
      this._velocity = _vel;
    }

    public override void ShowCar()
    {
      base.ShowCar();
      Console.WriteLine($"Количество пассажиров: {this._passengersQuantity}");
    }
  }
}

