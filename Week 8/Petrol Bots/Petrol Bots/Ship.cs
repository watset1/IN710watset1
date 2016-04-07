using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Bots
{
    public class Ship
    {
        public delegate void OutOfFuelEventHandler(object botShip, ShipEventArgs oe);
        public event EventHandler fullOfFuelEvent;
        public event OutOfFuelEventHandler outOfFuelEvent;


        public double Petrol { get; set; }
        Graphics shipCanvas;
        Rectangle boundaryRectangle;
        Color shipColor;
        Point shipLocation;
        int shipSize;
        EShipState shipState;
        Point shipVelocity;
        double MaxPetrol;

        public Point ShipLocation { get; set; }

        public Ship(Graphics shipCanvas, Rectangle boundaryRectangle, int shipSize, Random rGen)
        {
            MaxPetrol = rGen.Next(50,100);
            Petrol = MaxPetrol;
            this.shipCanvas = shipCanvas;
            this.boundaryRectangle = boundaryRectangle;
            shipLocation = new Point(rGen.Next(boundaryRectangle.Width - shipSize), rGen.Next(boundaryRectangle.Height - shipSize));
            this.shipSize = shipSize;
            shipState = EShipState.WANDERING;
            shipVelocity = new Point(rGen.Next(10), rGen.Next(10));
        }

        private void drawShip()
        {
            double petrolRatio = Petrol / 100.0;
            double redValue = 255 * petrolRatio;
            shipColor = Color.FromArgb((int)redValue, 0, 0);
            SolidBrush shipBrush = new SolidBrush(shipColor);

            shipCanvas.FillRectangle(shipBrush, shipLocation.X, shipLocation.Y, shipSize, shipSize);
        }

        private void moveShip()
        {
            if (shipState == EShipState.WANDERING)
            {
                shipLocation.X += shipVelocity.X;
                shipLocation.Y += shipVelocity.Y;

                if ((shipLocation.X <= boundaryRectangle.Left) || (shipLocation.X + shipSize > boundaryRectangle.Right))
                    shipVelocity.X *= -1;
                if ((shipLocation.Y <= boundaryRectangle.Top) || (shipLocation.Y + shipSize > boundaryRectangle.Bottom))
                    shipVelocity.Y *= -1;
            }
        }

        public void OnFullOfFuelEvent()
        {
            EventArgs e = null;
            if (fullOfFuelEvent != null)
                fullOfFuelEvent(this, e);
        }

        public void OnOutOfFuelEvent()
        {
            ShipEventArgs oe = new ShipEventArgs(shipLocation);

            if (outOfFuelEvent != null)
                outOfFuelEvent(this, oe);
        }

        private void refuel()
        {
            if (Petrol < MaxPetrol)
                Petrol++;
            else
                shipState = EShipState.WANDERING;
            OnOutOfFuelEvent();
        }
        
        public void ShipCycle()
        {
            drawShip(); 
            switch (shipState)
            {
                case EShipState.WANDERING:
                    moveShip();
                    usePetrol();                    
                    break;
                case EShipState.REFUELING:                    
                    refuel();               
                    break;
                default:
                    break;
            }                      
        }

        private void usePetrol()
        {
            if (Petrol > 0)
                Petrol --;
            else
                shipState = EShipState.REFUELING;
            OnFullOfFuelEvent();
        }
    }
}
