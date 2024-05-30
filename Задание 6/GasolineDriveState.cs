using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class GasolineDriveState:IDriveState
    {
        private double fuelConsumptionPerKm;
        public GasolineDriveState(double consumption)
        {
            fuelConsumptionPerKm = consumption;
        }
        public double GetFuelConsumption()
        {
            return fuelConsumptionPerKm;
        }
    }
}
