using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class HybridCar : IDriveState
    {
        private IDriveState _currentState;
        public enum DriveMode
        {
            Electric,
            Gasoline
        }
        public DriveMode Mode { get; private set; }
        public HybridCar(DriveMode mode)
        {
            SetDriveMode(mode, 0);
        }
        public void SetDriveMode(DriveMode mode, double consumption)
        {
            Mode = mode;
            switch (mode)
            {
                case DriveMode.Electric:
                    _currentState = new ElectricDriveState();
                    break;
                case DriveMode.Gasoline:
                    _currentState = new GasolineDriveState(consumption);
                    break;
            }
        }
        public double GetFuelConsumption()
        {
            return _currentState.GetFuelConsumption();
        }
    }
}
