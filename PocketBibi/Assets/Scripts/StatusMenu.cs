/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: StatusMenu.cs
 * Date Created: March 16 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: March 17 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PocketBibi
{
    public class StatusMenu : MonoBehaviour
    {
        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private GameScreen _gameScreen = null;
        [SerializeField] private GameObject _statusMenu = null;
        [SerializeField] private GameObject _settingsMenu = null;
        [SerializeField] private TextMeshProUGUI _name = null;
        [SerializeField] private TextMeshProUGUI _currency = null;
        [SerializeField] private TextMeshProUGUI _education = null;
        [SerializeField] private TextMeshProUGUI _career = null;
        [SerializeField] private TextMeshProUGUI _dateOfBirth = null;
        [SerializeField] private TextMeshProUGUI _age = null;
        [SerializeField] private TextMeshProUGUI _weight = null;
        [SerializeField] private TextMeshProUGUI _happiness = null;
        [SerializeField] private TextMeshProUGUI _hunger = null;
        [SerializeField] private Image _bibiImage = null;

        #endregion

        #region Private Initialization Functions/Methods

        private void OnEnable()
        {
            _statusMenu.SetActive(true);
            _settingsMenu.SetActive(false);

            _name.text = PlayerManager.Instance.PlayerBibi.Name;
            _currency.text = PlayerManager.Instance.PlayerBibi.Currency.ToString();
            _age.text = PlayerManager.Instance.PlayerBibi.Age.ToString();
            _happiness.text = PlayerManager.Instance.PlayerBibi.Happiness.ToString();
            _bibiImage.sprite = PlayerManager.Instance.PlayerBibi.BibiSprite;
        }

        private void OnDisable()
        {
            _statusMenu.SetActive(true);
            _settingsMenu.SetActive(false);
        }

        #endregion

        #region Public Functions/Methods for use with Buttons

        public void StatusButton()
        {
            _statusMenu.SetActive(false);
            _settingsMenu.SetActive(true);
        }

        public void SettingsButton()
        {
            _statusMenu.SetActive(true);
            _settingsMenu.SetActive(false);
        }

        public void BackButton()
        {
            gameObject.SetActive(false);
            _gameScreen.InSideButton();
        }

        #endregion
    }
}