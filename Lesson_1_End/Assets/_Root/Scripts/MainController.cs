using Ui;
using Game;
using Profile;
using UnityEngine;

internal class MainController : BaseController
{
    private readonly Transform _placeForUi;
    private readonly ProfilePlayer _profilePlayer;

    private MainMenuController _mainMenuController;
    private GameController _gameController;
    private SettingMenuController _settingMenuController;


    public MainController(Transform placeForUi, ProfilePlayer profilePlayer)
    {
        _placeForUi = placeForUi;
        _profilePlayer = profilePlayer;

        profilePlayer.CurrentState.SubscribeOnChange(OnChangeGameState);
        OnChangeGameState(_profilePlayer.CurrentState.Value);
    }

    protected override void OnDispose()
    {
        _mainMenuController?.Dispose();
        _gameController?.Dispose();

        _profilePlayer.CurrentState.UnSubscribeOnChange(OnChangeGameState);
    }


    private void OnChangeGameState(GameState state)
    {
        switch (state)
        {
            case GameState.Start:
                _mainMenuController = new MainMenuController(_placeForUi, _profilePlayer);
                _gameController?.Dispose();
                _settingMenuController?.Dispose();
                break;
            case GameState.Game:
                _gameController = new GameController(_profilePlayer);
                _mainMenuController?.Dispose();
                _settingMenuController?.Dispose();
                break;
            case GameState.Setting:
                _settingMenuController = new SettingMenuController(_placeForUi, _profilePlayer);
                _mainMenuController?.Dispose();
                _gameController?.Dispose();
                break;
            default:
                _mainMenuController?.Dispose();
                _gameController?.Dispose();
                _settingMenuController?.Dispose();
                break;
        }
    }
}