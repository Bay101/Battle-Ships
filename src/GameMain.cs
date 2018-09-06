using System;
using SwinGameSDK;
 // requires mcs version 4+, 
// using SwinGameSDK.SwinGame; // requires mcs version 4+, 

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            // Opens a new Graphics Window
            SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

            // Load Resources
            SwinGameLoadResources();

            SwinGame.PlayMusic(GameMusic("Background"));

            // Game Loop
            do
            {
                SwinGame.ProcessEvents();
                SwinGame.RefreshScreen();
            }
            while (!SwinGame.WindowCloseRequested() == true | CurrentState == GameState.Quitting);

            SwinGame.StopMusic();

            // Free Resources and Close Audio, to end the program.
            SwinGame.FreeResources();
        }
    }
}
