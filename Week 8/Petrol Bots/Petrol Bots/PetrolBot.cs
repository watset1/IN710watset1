using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Bots
{
    public class PetrolBot
    {
        Graphics botCanvas;
        Color botColor;
        Point botCurrentLocation;
        Ship botShip;
        Point botStartingLocation;

        public PetrolBot(Graphics botCanvas, Ship botShip, Point botStartingLocation, Random rGen)
        {
            this.botCanvas = botCanvas;
            botColor = Color.FromArgb(rGen.Next(255), rGen.Next(255), rGen.Next(255));
            this.botStartingLocation = botStartingLocation;
            this.botCurrentLocation = botStartingLocation;
            this.botShip = botShip;           

            EventHandler fullOfFuelHandler = new EventHandler(FullOfFuelEventHandlerMethod);
            Ship.OutOfFuelEventHandler outOfFuelHandler = new Ship.OutOfFuelEventHandler(OutOfFuelEventHandlerMethod);
            botShip.fullOfFuelEvent += fullOfFuelHandler;
            botShip.outOfFuelEvent += outOfFuelHandler;
            drawBot();
        }
        
        private void drawBot()
        {
            SolidBrush botBrush = new SolidBrush(botColor);
            botCanvas.FillEllipse(botBrush, botCurrentLocation.X, botCurrentLocation.Y, 15, 15);
        }

        public void FullOfFuelEventHandlerMethod(object botShip, EventArgs e)
        {
            
            botCurrentLocation = botStartingLocation;
            drawBot();
        }

        public void OutOfFuelEventHandlerMethod(object botShip, ShipEventArgs oe)
        {
            
            botCurrentLocation = oe.ShipLocation;
            drawBot();
        }
    }
}
