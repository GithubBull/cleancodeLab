﻿using System.Runtime.InteropServices;
using LabbCC.Interfaces;

namespace LabbCC;

public class GameController : IGameController
{
    public List<IGame> games = new List<IGame>();
    private readonly IUI ui = new ConsoleIO();
    public GameController()
    {
        games.Add(new MooGame("Moo"));
    }
    public void SelectGame()
    {
        bool running = true;
        while (running)
        {
            ui.Output("Please select game:\n");
            ui.Output($"1. {games[0].GameName}");
            ui.Output("0. Exit menu");
            int.TryParse(ui.Input(), out int selectGame); 
            switch (selectGame)
            {
                case 0:
                    ui.ExitGame();
                    break;
                case 1:
                    games[0].RunGame();
                    break;
                case 2:
                    //Annat spel
                    break;
                default:
                    ui.Output("Choose a number for an existing game");
                    break;
            }

        }
    }
    public bool Continue()
    {
        bool runLoop = true;
        while (runLoop)
        {
            ui.Output("\nContinue? \nYes(y) / No(n)");
            string answer = ui.Input();
            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer == "n".ToLower())
            {
                return false;
            }
            else
                ui.Clear();
            ui.Output("Please enter 'y' to continue or 'n' to quit");

        }
        return false;
    }
}
