using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.Collections.Generic;

namespace Tool.Bundles.Examples
{
    internal class AssetBundlesLoadWindowPracticeView : AssetBundleViewBase
    {
    [Header("Asset Bundles")]
    [SerializeField] private Button _loadBackgroundForBigButton;


    private void Start()
    {
        _loadBackgroundForBigButton.onClick.AddListener(LoadAssets);
    }

    private void OnDestroy()
    {
        _loadBackgroundForBigButton.onClick.RemoveAllListeners();
    }


    private void LoadAssets()
    {
        _loadBackgroundForBigButton.interactable = false;
        StartCoroutine(DownloadAndSetAssetBundles());
    }

    }
}
