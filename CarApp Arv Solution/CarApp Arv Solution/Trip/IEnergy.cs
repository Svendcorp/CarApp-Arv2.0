using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{
    public interface IEnergy
    {
        double EnergyLevel { get; set; }

        double MaxEnergy { get; set; }

        void Refill(double amount);

        void UseEnergy(double distance);
    }
}
