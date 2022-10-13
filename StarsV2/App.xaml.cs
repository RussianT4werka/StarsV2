using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StarsV2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IGameControl gameControl = new GameControl();

            IGameUI gameUI = new GameUI();

            IGameCore gameCore = new GameCore(gameControl, gameUI);
            gameCore.Start();
        }
    }
}
