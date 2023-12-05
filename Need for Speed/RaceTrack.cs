using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Need_for_Speed
{
    public class RaceTrack
    {
        private int distance;
        public RaceTrack(int Distance) 
        {
            this.distance = Distance;
        }
        public bool TryFinishTrack(RemoteControlCar remotecontrolcar)
        {
            while (remotecontrolcar.DistanceDriven() < distance)
            {
                
                if ((remotecontrolcar.BatteryDrained()))
                    {
                        return false;
                    }
                remotecontrolcar.Drive();
            }
            return true;

        }
    }
}
