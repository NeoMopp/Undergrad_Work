using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Rovio
{
    class Predator : MyRobot
    {
        //----------Variables Start Here----------//
        private RoboState currentState = RoboState.FIND;
        private ObjectPosition redPos = ObjectPosition.OBJ_UNKNOWN;
        private ObjectPosition greenPos = ObjectPosition.OBJ_UNKNOWN;
        //----------Variables End Here----------//
        private enum RoboState
        {
            FIND,
            SEARCH,
            FOLLOW_RED,
            FOLLOW_GREEN,
            CAPTURED
        }

        private enum ObjectPosition
        {
            OBJ_UNKNOWN,
            OBJ_INFRONT,
            OBJ_LEFT,
            OBJ_RIGHT,
            OBJ_FOUND
        }

        public Predator(string address, string username, string password)
            : base(address, username, password)
        {
        }

        //----------State Machine starts here----------//
        public void stateMachine()
        {
            this.Camera.Resolution = Rovio.API.Camera.ImageResolution.CIF;
            while (true)
            {
                switch (currentState)
                {
                    case RoboState.FIND:
                        this.find();
                        break;
                    case RoboState.FOLLOW_RED:
                        this.followRED();
                        break;
                    case RoboState.FOLLOW_GREEN:
                        this.followGREEN();
                        break;
                    case RoboState.CAPTURED:
                        break;
                    case RoboState.SEARCH:
                        this.searchSpace();
                        break;
                    default:
                        break;
                }
            }
        }
        
        //Just a funny little thing.
        //Would run when the Rovio has caught its prey.
        private void captured()
        {
            this.API.Movement.ManualDrive.HeadMiddle();
            this.API.Movement.ManualDrive.HeadUp();
            this.RotateLeft90(3);
            this.RotateLeft90(3);
            this.RotateLeft90(3);
            this.RotateLeft90(3);
        }

        //Looks ONLY for RED
        private void find()
        {
            while (currentState == RoboState.FIND)
            {
                processImage();
            }

        }

        //Controller for the state machine when it is in the FOLLOW_RED state
        private void followRED()
        {
            while (currentState == RoboState.FOLLOW_RED)
            {
                switch (redPos)
                {
                    case ObjectPosition.OBJ_INFRONT:
                        if (!this.IRSensor.Detection)
                        {
                            this.Drive.Forward(10);
                            //this.Drive.Stop();
                            redPos = ObjectPosition.OBJ_UNKNOWN;
                            currentState = RoboState.FIND;
                            break;
                        }
                        else
                        {
                            redPos = ObjectPosition.OBJ_UNKNOWN;
                            currentState = RoboState.FIND;
                            break;
                        }
                    case ObjectPosition.OBJ_LEFT:
                        this.API.Movement.ManualDrive.RotateLeft(10);
                        //this.Drive.Stop();
                        redPos = ObjectPosition.OBJ_UNKNOWN;
                        currentState = RoboState.FIND;
                        break;
                    case ObjectPosition.OBJ_RIGHT:
                        this.API.Movement.ManualDrive.RotateRight(10);
                        //this.Drive.Stop();
                        redPos = ObjectPosition.OBJ_UNKNOWN;
                        currentState = RoboState.FIND;
                        break;
                    case ObjectPosition.OBJ_UNKNOWN:
                        redPos = ObjectPosition.OBJ_UNKNOWN;
                        currentState = RoboState.FIND;
                        break;
                    default:
                        currentState = RoboState.FIND;
                        break;

                }
            }
        }


        //Controller for the state machine when it is in the FOLLOW_GREEN state
        private void followGREEN()
        {
            while (currentState == RoboState.FOLLOW_GREEN)
            {
                switch (greenPos)
                {
                    case ObjectPosition.OBJ_INFRONT:
                        if (!this.IRSensor.Detection)
                        {
                            this.Drive.Forward(10);
                            greenPos = ObjectPosition.OBJ_UNKNOWN;
                            currentState = RoboState.FIND;
                            break;
                        }
                        else
                        {
                            greenPos = ObjectPosition.OBJ_UNKNOWN;
                            currentState = RoboState.FIND;
                            break;
                        }
                    case ObjectPosition.OBJ_LEFT:
                        this.Drive.StraightLeft(10);
                        greenPos = ObjectPosition.OBJ_UNKNOWN;
                        currentState = RoboState.FIND;
                        break;
                    case ObjectPosition.OBJ_RIGHT:
                        this.Drive.StraightRight(10);
                        greenPos = ObjectPosition.OBJ_UNKNOWN;
                        currentState = RoboState.FIND;
                        break;
                    case ObjectPosition.OBJ_UNKNOWN:
                        greenPos = ObjectPosition.OBJ_UNKNOWN;
                        currentState = RoboState.FIND;
                        break;
                    default:
                        currentState = RoboState.FIND;
                        break;

                }
            }
        }


        //Controller for the state machine when it is in the SEARCH state
        private void searchSpace()
        {
            while (currentState == RoboState.SEARCH)
            {
                this.Drive.Forward(1);
                this.Drive.RotateLeft(10);
                currentState = RoboState.FIND;
            }
        }


        //----------State Machine ends here----------//

        //----------Camera delegates start here----------//
        public delegate void ImageReady(Image image);

        public event ImageReady sourceImage;

        public event ImageReady filterImage;

        public event ImageReady filterImage2;

        public event ImageReady filterImage3;
        //----------Camera delegates end here----------//


        //----------Image Processing Starts Here----------//
        private void processImage()
        {
            Bitmap source = Camera.Image;
            Bitmap filtR = new Bitmap(source);
            Bitmap filtG = new Bitmap(source);
            Bitmap filtB = new Bitmap(source);
            filtR = redF(filtR);
            filtG = greenF(filtG);
            filtB = blueF(filtB);
            sourceImage(source);
            filterImage(filtR);
            filterImage2(filtG);
            filterImage3(filtB);
        }


        //Filter to find red
        private Bitmap redF(Bitmap image)
        {
            //Create Filter and set value ranges
            AForge.Imaging.Filters.HSLFiltering filter = new AForge.Imaging.Filters.HSLFiltering();
            filter.Hue = new AForge.IntRange(350, 25);
            filter.Saturation = new AForge.Range(0.5f, 1);
            filter.Luminance = new AForge.Range(0.15f, 1);
            filter.ApplyInPlace(image);
            //Create a blob counter to search through the image
            AForge.Imaging.BlobCounter extractor = new AForge.Imaging.BlobCounter();
            extractor.MinHeight = 5;
            extractor.MinWidth = 5;
            extractor.FilterBlobs = true;
            extractor.ProcessImage(image);
            //Gets the rectangles so that we can draw around them
            Rectangle[] rects = extractor.GetObjectsRectangles();
            if (rects.Length > 0)
            {
                Rectangle objectRect = rects[0];
                Graphics g = Graphics.FromImage(image);
                using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 2))
                {
                    g.DrawRectangle(pen, objectRect);
                }
                g.Dispose();
                //Get the direction and change state.
                objDirectionRed(objectRect, image.Width);
                 currentState = RoboState.FOLLOW_RED;
            }
            return image;
        }

        //Filter to find green
        private Bitmap greenF(Bitmap image)
        {
            //Create Filter and set value ranges
            AForge.Imaging.Filters.HSLFiltering filter = new AForge.Imaging.Filters.HSLFiltering();
            filter.Hue = new AForge.IntRange(95,180);
            filter.Saturation = new AForge.Range(0.3f, 1);
            filter.Luminance = new AForge.Range(0.1f, 1);
            filter.ApplyInPlace(image);
            //Create a blob counter to search through the image
            AForge.Imaging.BlobCounter extractor = new AForge.Imaging.BlobCounter();
            extractor.MinHeight = 5;
            extractor.MinWidth = 5;
            extractor.FilterBlobs = true;
            extractor.ProcessImage(image);
            //Gets the rectangles so that we can draw around them
            Rectangle[] rects = extractor.GetObjectsRectangles();
            if (rects.Length > 0)
            {
                Rectangle objectRect = rects[0];
                Graphics g = Graphics.FromImage(image);
                using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 2))
                {
                    g.DrawRectangle(pen, objectRect);
                }
                g.Dispose();
                //Get the direction and change state.
                objDirectionGreen(objectRect, image.Width);
                if (currentState != RoboState.FOLLOW_RED)
                    currentState = RoboState.FOLLOW_GREEN;
            }
            return image;
        }

        private Bitmap blueF(Bitmap image)
        {
            //Create Filter and set value ranges
            AForge.Imaging.Filters.HSLFiltering filter = new AForge.Imaging.Filters.HSLFiltering();
            filter.Hue = new AForge.IntRange(200,240);
            filter.Saturation = new AForge.Range(0.3f, 1);
            filter.Luminance = new AForge.Range(0.1f, 1);
            filter.ApplyInPlace(image);
            AForge.Imaging.BlobCounter extractor = new AForge.Imaging.BlobCounter();
            extractor.MinHeight = 5;
            extractor.MinWidth = 5;
            extractor.FilterBlobs = true;
            extractor.ProcessImage(image);
            //Create a blob counter to search through the image
            Rectangle[] rects = extractor.GetObjectsRectangles();
            if (rects.Length > 0)
            {
                Rectangle objectRect = rects[0];
                Graphics g = Graphics.FromImage(image);
                using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 2))
                {
                    g.DrawRectangle(pen, objectRect);
                }
                g.Dispose();
                //Get the direction and change state.
                if (currentState != RoboState.FOLLOW_RED && currentState != RoboState.FOLLOW_GREEN)
                   currentState = RoboState.SEARCH;
            }
            return image;
        }

        //----------Image Processing Ends Here----------//

        //----------Object Direction Starts Here----------//

        private void objDirectionRed(Rectangle rect, int imWidth)
        {
            if (imWidth * 0.3 > (rect.X + rect.Width))
                redPos = ObjectPosition.OBJ_LEFT;
            else if (imWidth * 0.6 < (rect.X + rect.Width))
                redPos = ObjectPosition.OBJ_RIGHT;
            else
                redPos = ObjectPosition.OBJ_INFRONT;
        }

        private void objDirectionGreen(Rectangle rect, int imWidth)
        {
            if (imWidth * 0.3 > (rect.X + rect.Width))
                greenPos = ObjectPosition.OBJ_LEFT;
            else if (imWidth * 0.6 < (rect.X + rect.Width))
                greenPos = ObjectPosition.OBJ_RIGHT;
            else
            {
                greenPos = ObjectPosition.OBJ_INFRONT;
                if (rect.Height > 90)
                    currentState = RoboState.CAPTURED;
            }
        }
        //----------Object Direction Ends Here----------//


        //----------Functions to get some basic data to output to the user so they know what is going on.
        public string getState()
        {
            return currentState.ToString();
        }

        public string getDir()
        {
            if (currentState == RoboState.FOLLOW_RED)
            {
                return redPos.ToString();
            }

            else if (currentState == RoboState.FOLLOW_GREEN)
            {
                return greenPos.ToString();
            }

            return "NULL";
        }

        public string getColour()
        {
            if (currentState == RoboState.FOLLOW_RED)
                return "RED";
            else if (currentState == RoboState.FOLLOW_GREEN)
                return "GREEN";
            else
                return "NONE";
        }

    }
}