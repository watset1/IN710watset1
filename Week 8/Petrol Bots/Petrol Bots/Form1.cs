using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Bots
{
    public partial class Form1 : Form
    {
        const int SHIP_SIZE = 40;
        const int NUM_SHIPS = 5;
        const int BOT_SPACING = 20;
        const int BOT_INITIAL_X = 5;
        const int BOT_VERTICAL_POSTION = 576;
        const int DOCK_HEIGHT = 70;

        List<PetrolBot> botList;
        Graphics mainCanvas;
        Bitmap offScreenBitmap;
        Graphics offScreenGraphics;
        Rectangle boundaryRectangle;
        List<Ship> shipList;
        Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            mainCanvas = CreateGraphics();
            offScreenBitmap = new Bitmap(Width, Height);
            offScreenGraphics = Graphics.FromImage(offScreenBitmap);
            boundaryRectangle = new Rectangle(0,0, Width, Height - DOCK_HEIGHT);
            shipList = new List<Ship>();
            botList = new List<PetrolBot>();
            populateLists();         
        }

        private void populateLists()
        {
            int botSpacing = BOT_INITIAL_X;
            for (int i = 0; i < NUM_SHIPS; i++)
            {
                shipList.Add(new Ship(offScreenGraphics, boundaryRectangle, SHIP_SIZE, random));
                botList.Add(new PetrolBot(offScreenGraphics, shipList[i], new Point(botSpacing, BOT_VERTICAL_POSTION), random));
                botSpacing += BOT_SPACING;
            }         
        }

        private void drawShips()
        {
            foreach (Ship ship in shipList)            
                ship.ShipCycle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            offScreenGraphics.FillRectangle(Brushes.SkyBlue, 0, 0, Width, Height);
            offScreenGraphics.FillRectangle(Brushes.BurlyWood, 0, Height - DOCK_HEIGHT, Width, DOCK_HEIGHT);
            drawShips();
            mainCanvas.DrawImage(offScreenBitmap, 0, 0);      
        }
    }
}
