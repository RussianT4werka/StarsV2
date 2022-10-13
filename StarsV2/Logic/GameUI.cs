using System;
using System.Windows.Controls;

namespace StarsV2
{
    internal class GameUI : IGameUI
    {
        Game window;
        Canvas mainCanvas;
        public void Init()
        {
            window = new Game();
            mainCanvas = window.Canva;
        }
    }
}