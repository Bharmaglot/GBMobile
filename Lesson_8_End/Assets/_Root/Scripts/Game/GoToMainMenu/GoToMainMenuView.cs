using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

namespace Ui
{
    public class GoToMainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _goToMainMenuButton;

        public void Init(UnityAction backToMenu) => _goToMainMenuButton.onClick.AddListener(backToMenu);

        public void OnDestroy() => _goToMainMenuButton.onClick.RemoveAllListeners();
    }
}
