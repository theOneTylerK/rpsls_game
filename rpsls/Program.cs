using System;
using System.Collections.Generic;

namespace rpsls
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Gestures gestures = new Gestures();
            gestures.ChooseGesture();
            Player pla = new Player(1);
            pla.MakeChoice("rock");
        }
    }
}
