using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Need_for_Speed
{
    public class RemoteControlCar
    {
        private int speed ;
        private int batteryDrain;
        private int distanceDriven;
        private int batterylevel;

        public RemoteControlCar(int Speed, int BatteryDrain)
        {
            this.speed = Speed;
            this.batteryDrain =BatteryDrain;
            distanceDriven = 0;
            batterylevel = 100;
        }

        public int Battery()
        {
            return batterylevel;
        }
        public bool BatteryDrained()
        {
            return batterylevel < 0;
        }
        public void Drive()
        {
            if(!BatteryDrained())
            {
                distanceDriven += speed;
                batterylevel -= batteryDrain;
            }
           
        }
        public int DistanceDriven() 
        {
            return distanceDriven;
        }
        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50, 4);

        }
    }
}
