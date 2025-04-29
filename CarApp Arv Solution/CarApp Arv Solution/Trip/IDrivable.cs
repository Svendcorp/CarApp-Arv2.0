using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{
    public interface IDrivable
    {

        void StartEngine(bool isEngineOn);


        void StopEngine(bool isEngineOn);


        void Drive(double distance) { }

        void CanDrive(double distance) { }

    }
}
