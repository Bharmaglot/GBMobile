using Tool;
using Game.Car;
using Features.Inventory;

namespace Profile
{
    internal class ProfilePlayer
    {
        public readonly SubscriptionProperty<GameState> CurrentState;
        public readonly CarModel CurrentCar;
        public readonly InventoryModel Inventory;


        public ProfilePlayer(float speedCar, float jumpHeigth, GameState initialState) : this(speedCar, jumpHeigth)
        {
            CurrentState.Value = initialState;
        }

        public ProfilePlayer(float speedCar, float jumpHeigth)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new CarModel(speedCar, jumpHeigth);
            Inventory = new InventoryModel();
        }
    }
}
