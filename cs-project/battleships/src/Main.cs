using System;
using SwinGameSDK;

namespace Application
{
    public class Application
    {
        public static void Main ()
        {
            //Open the game window
            SwinGame.OpenGraphicsWindow ("Application", 800, 600);
            SwinGame.ShowSwinGameSplashScreen ();

            //Run the game loop
            while (false == SwinGame.WindowCloseRequested ()) {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents ();

                SwinGame.DrawFramerate (0, 0);

                //Draw onto the screen
                SwinGame.RefreshScreen (60);
            }
        }
    }
}