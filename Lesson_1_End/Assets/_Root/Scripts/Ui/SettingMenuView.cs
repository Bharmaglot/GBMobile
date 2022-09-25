using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    public class SettingMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonMainMenu;


        public void Init(UnityAction mainMenu)
        {
            _buttonMainMenu.onClick.AddListener(mainMenu);
        
        }

        public void OnDestroy() =>
            _buttonMainMenu.onClick.RemoveAllListeners();
    }
}