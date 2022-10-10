using Profile;
using UnityEngine;

internal class EntryPoint : MonoBehaviour
{
    [Header("Scene Objects")]
    [SerializeField] private Transform _placeForUi;

   [SerializeField] private EntryPointConfig entryPointConfig;

   

    private MainController _mainController;


    private void Start()
    {
        var profilePlayer = new ProfilePlayer(entryPointConfig.SpeedCar, entryPointConfig.InitialState);
        _mainController = new MainController(_placeForUi, profilePlayer);
    }

    private void OnDestroy()
    {
        _mainController.Dispose();
    }
}
