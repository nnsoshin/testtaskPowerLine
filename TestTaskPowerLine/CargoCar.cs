using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskPowerLine
{
  class CargoCar : Car
  {
    protected float _additionalWeight { get; set; }

    protected const float MaxAddiotionalWeight = 2000;

    protected override float CalculateAvailableDistance(float _fuelTankFullness)
    {
      float _distanceMultiplier = 1;

      if (this._additionalWeight is >= 0 and <= MaxAddiotionalWeight)
      {
        _distanceMultiplier -= ((int)(_additionalWeight / 200) * 4) / 100;
      }
      return base.CalculateAvailableDistance(this._fuelTankCapacity) * _distanceMultiplier;
    }

    public CargoCar(float _avg, float _capacity, float _weight, float _vel)
    {
      this._type = CarType.CargoCar;
      this._avgFuelConsumption = _avg;
      this._fuelTankCapacity = _capacity;
      this._additionalWeight = _weight;
      this._velocity = _vel;
    }

    public override void ShowCar()
    {
      base.ShowCar();
      Console.WriteLine($"Дополнительный груз: {this._additionalWeight}");
    }
  }
}
