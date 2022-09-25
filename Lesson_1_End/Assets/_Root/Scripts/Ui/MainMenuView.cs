using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonStart;
        [SerializeField] private Button _buttonSetting;



        public void Init(UnityAction startGame)
        {
            _buttonStart.onClick.AddListener(startGame);

        }

        public void MoveToSetting(UnityAction SettingMenu)
        {
            _buttonSetting.onClick.AddListener(SettingMenu);
        }
            

        public void OnDestroy()
        {
            _buttonStart.onClick.RemoveAllListeners();
            _buttonSetting.onClick.RemoveAllListeners();
        }

    }
}
