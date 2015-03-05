using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rovio
{
    class MyRobot : Robot
    {
        
        public MyRobot(string address, string user, string password)
            : base(address, user, password)
        {}

        //Move forward/backward at speed velocity for revolutions of repetions
        public void DriveStraight(int velocity, int repetitions)
        {
            if ((velocity > 0) && (velocity < 11))
            {
                for (int x = 0; x < repetitions; x++)
                {
                    Drive.Forward(velocity);
                }
            }

            else if ((velocity < 0) && (velocity > -11))
            {
                velocity = velocity * -1;
                for (int x = 0; x < repetitions; x++)
                {
                    Drive.Backward(velocity);
                }
            }

            else
                System.Windows.Forms.MessageBox.Show("Invalid Command");
        }

        //Turn left/right at speed velocity for revolutions of repetions
        public void Spin(int velocity, int repetitions)
        {
            if ((velocity > 0) && (velocity < 11))
            {
                for (int x = 0; x < repetitions; x++)
                {
                    Drive.RotateLeft(velocity);
                }
            }

            else if ((velocity < 0) && (velocity > -11))
            {
                velocity = velocity * -1;
                for (int x = 0; x < repetitions; x++)
                {
                    Drive.RotateRight(velocity);
                }
            }

            else
                System.Windows.Forms.MessageBox.Show("Invalid Command");
        }

        //additional implmentations
        public void DriveDistance(double distance, int velocity)
        {}

        public void DriveStraightOdo(double distance, int velocity)
        {
            int left = Odometry.LeftWheelTicks;
            int right = Odometry.RightWheelTicks;
        }

        public void SpinOdo(double angel, int velocity)
        {}
        //end of additionals

        public void RotateRight90(int speed) { this.API.Movement.ManualDrive.RotateRight90(speed); ; }
        public void RotateLeft90(int speed) { this.API.Movement.ManualDrive.RotateLeft90(speed); }

        //http://192.168.0.4/rev.cgi?Cmd=nav&action=18&drive=18&speed=1&angle=7
        //http://192.168.0.4/rev.cgi?Cmd=nav&action=18&drive=17&speed=1&angle=7

    }
}
