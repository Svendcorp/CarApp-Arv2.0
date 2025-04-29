using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{
    public interface IDrivable
    {

        void StartEngine();


        void StopEngine();


        public virtual void Drive(double distance) { }

        public virtual void CanDrive(double distance) { }

    }
}
