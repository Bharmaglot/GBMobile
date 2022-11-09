using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.Collections.Generic;

namespace Tool.Bundles.Examples
{
    internal class AdressablesLoadWindowPracticeView : AssetBundleViewBase
    {
        [Header("Asset Reference")]
        [SerializeField] private AssetReference _canvasBackground;
        [SerializeField] private AssetReference _buttonsBackground;
        [Header("Buttons")]
        [SerializeField] private Button _activateBackground;
        [SerializeField] private Button _deactivateBackground;
        [Header("Backgrounds")]
        [SerializeField] private Image _canvasBackgroundImage;
        [SerializeField] private Image _activateBackgroundImage;
        [SerializeField] private Image _deactivateBackgroundImage;





        private void Start()
        {
            _activateBackground.onClick.AddListener(OnBackground);
            _deactivateBackground.onClick.AddListener(OffBackground);
            _deactivateBackground.interactable = false;
        }

        private void OnBackground()
        {
            ActivateBackground();
            SwitchToButtonDeactivate();
        }

        private void OffBackground()
        {
            DeactivateBackground();
            SwitchToButtonActivate();
        }

        private async void ActivateBackground()
        {
        AsyncOperationHandle<Sprite> handle = _canvasBackground.LoadAssetAsync<Sprite>();
        await handle.Task;
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                Sprite sprite = handle.Result;

                _canvasBackgroundImage.sprite = sprite;

                Addressables.Release(handle);
            }
        }
      


        private void DeactivateBackground()
        {
            _canvasBackgroundImage.sprite = null;
        }

        private void SwitchToButtonActivate()
        {
            _deactivateBackground.interactable = false;
            _activateBackground.interactable = true;
        }

        private void SwitchToButtonDeactivate()
        {
            _deactivateBackground.interactable = true;
            _activateBackground.interactable = false;
        }
    }
}