﻿using ConsoleTableExt;

namespace Screens;

public class MainMenu
{
    AskInputs.AskInput askInput = new();
    public void View()
    {
        StacksMenu stacksMenu = new();
        CardsMenu cardsMenu = new();

        bool exitMenu = false;
        List<object> optionsString = new List<object> {
            "1 - New Session",
            "2 - Stacks",
            "3 - Cards",
            "0 - Exit App"};

        while (!exitMenu)
        {
            Console.Clear();
            ConsoleTableBuilder.From(optionsString)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .WithColumn("FlashCards")
                .ExportAndWriteLine();
            Console.Write("\n");
            switch (askInput.PositiveNumber("Please select a valid option"))
            {
                case 0: exitMenu = true; break;
                case 1: break;
                case 2: stacksMenu.View(); break;
                case 3: cardsMenu.View(); break;
                case 4: break;
                case 5: break;
                case 6:  break;
                default: break;
            }
        }
        return;
    }
}
