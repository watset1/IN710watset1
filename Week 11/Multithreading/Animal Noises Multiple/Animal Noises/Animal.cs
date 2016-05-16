using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        private String soundFileName;
        private Form1 form;

        public Animal(String soundFileName, Form1 form)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            this.form = form;
        }

        public void speak()
        {
            while (true)
            {
                lock (form)
                {
                    soundPlayer.PlaySync();
                }
            }
        }
    }
}
