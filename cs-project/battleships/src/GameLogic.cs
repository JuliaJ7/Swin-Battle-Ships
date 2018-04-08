using SwinGameSDK;
using System;

public class GameLogic
{

    public static void Main ()
    {
        // Opens a new Graphics Window
        SwinGame.OpenGraphicsWindow ("Battle Ships", 800, 600);
        // Load Resources
        GameResources.LoadResources ();
        //SwinGame.PlayMusic (GameResources.GameMusic ("Background"));

        // TODO(Xavier): This a a hacky fix. Instead turn this into an
        // init() static method for the game controller.
        GameController controller = new GameController ();

        // Game Loop
        do {
            GameController.HandleUserInput ();
            GameController.DrawScreen ();
        } while ((((SwinGame.WindowCloseRequested () == true) || (GameController.CurrentState == GameState.Quitting)) == false));

        SwinGame.StopMusic ();
        // Free Resources and Close Audio, to end the program.
        GameResources.FreeResources ();
    }

}