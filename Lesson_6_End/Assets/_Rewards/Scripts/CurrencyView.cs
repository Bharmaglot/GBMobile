using UnityEngine;

namespace Rewards
{
    internal class CurrencyView : MonoBehaviour
    {
        private const string WoodKey = nameof(WoodKey);
        private const string DiamondKey = nameof(DiamondKey);
        private const string FoodKey = nameof(FoodKey);
        private const string GoldKey = nameof(GoldKey);


        private static CurrencyView _instance;
        public static CurrencyView Instance => _instance;

        [SerializeField] private CurrencySlotView _currencyWood;
        [SerializeField] private CurrencySlotView _currentDiamond;
        [SerializeField] private CurrencySlotView _currentFood;
        [SerializeField] private CurrencySlotView _currentGold;


        private int Wood
        {
            get => PlayerPrefs.GetInt(WoodKey);
            set => PlayerPrefs.SetInt(WoodKey, value);
        }

        private int Diamond
        {
            get => PlayerPrefs.GetInt(DiamondKey);
            set => PlayerPrefs.SetInt(DiamondKey, value);
        }

        private int Gold
        {
            get => PlayerPrefs.GetInt(GoldKey);
            set => PlayerPrefs.SetInt(GoldKey, value);
        }

        private int Food
        {
            get => PlayerPrefs.GetInt(FoodKey);
            set => PlayerPrefs.SetInt(FoodKey, value);
        }

        private void Awake() =>
            _instance = this;

        private void OnDestroy() =>
            _instance = null;

        private void Start()
        {
            _currencyWood.SetData(Wood);
            _currentDiamond.SetData(Diamond);
            _currentGold.SetData(Gold);
            _currentFood.SetData(Food);

        }


        public void AddWood(int value)
        {
            Wood += value;
            _currencyWood.SetData(Wood);
        }

        public void AddDiamond(int value)
        {
            Diamond += value;
            _currentDiamond.SetData(Diamond);
        }

        public void AddGold(int value)
        {
            Gold += value;
            _currentGold.SetData(Gold);
        }

        public void AddFood(int value)
        {
            Diamond += value;
            _currentFood.SetData(Food);
        }
    }
}
