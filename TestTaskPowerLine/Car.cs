using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskPowerLine
{
  abstract class Car
  {
    protected CarType _type;

    protected float _avgFuelConsumption; // per 100 km

    protected float _fuelTankCapacity;

    protected float _velocity;


    protected virtual float CalculateAvailableDistance(float _fuelTankFullness = 0)
    {
      return _fuelTankFullness != 0 ? (_fuelTankFullness * 100) / _avgFuelConsumption : 0;
    }

    protected float CalculateTimePeriodToCoverDistance(float _distance) {
      return _distance / this._velocity;
    }

    public virtual void ShowCar()
    {

      float _maxDistance = this.CalculateAvailableDistance(this._fuelTankCapacity);

      Console.WriteLine("\nХарактеристики машины.");
      Console.WriteLine($"Тип: { this._type}");
      Console.WriteLine($"Средний расход: {this._avgFuelConsumption}");
      Console.WriteLine($"Количество топлива: {this._fuelTankCapacity}");
      Console.WriteLine($"Средняя скорость: {this._velocity}");
      Console.WriteLine($"Максимальная дистанция: {_maxDistance}");
      Console.WriteLine($"За сколько преодолеет макс.дистанцию: {this.CalculateTimePeriodToCoverDistance(_maxDistance)}");
    }

    protected enum CarType
    {
      LightCar,
      CargoCar,
      SportCar
    }

  }
}
