namespace StarsV2
{
    internal class GameCore : IGameCore
    {
        private IGameControl gameControl;
        private IGameUI gameUI;
        public GameCore(IGameControl gameControl, IGameUI gameUI)
        {
            this.gameControl = gameControl;
            this.gameUI = gameUI;
        }

        public void Start()
        {
            gameUI.Init();
        }

    }
}