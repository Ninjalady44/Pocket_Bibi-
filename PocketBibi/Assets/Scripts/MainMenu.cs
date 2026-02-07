/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: MainMenu.cs
 * Date Created: January 30 2026
 * Created By: Richard Als
 * Description: Handles menu buttons and panels
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: February 06 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PocketBibi
{
    public class MainMenu : MonoBehaviour
    {
        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private GameObject _startButton = null;
        [SerializeField] private GameObject _gameSelection = null;
        [SerializeField] private GameObject _eggSelection = null;
        [SerializeField] private GameObject _nameSelection = null;
        [SerializeField] private GameObject _confirmSelection = null;
        [SerializeField] private GameObject _eggHatchingScreen = null;

        [SerializeField] private GameScreen _gameScreen = null;
        [SerializeField] private TMP_InputField _nameInputField = null;
        [SerializeField] private TextMeshProUGUI _nameText = null;
        [SerializeField] private Image _image = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private List<GameObject> _menuPanels;
        private int _egg;

        #endregion

        #region Private Initialization Functions/Methods

        void Start()
        {
            _menuPanels = new List<GameObject>();
            _menuPanels.Add(_startButton);
            _menuPanels[0].SetActive(true);
            _gameSelection.SetActive(false);
            _eggSelection.SetActive(false);
            _nameSelection.SetActive(false);
            _confirmSelection.SetActive(false);
        }

        #endregion

        #region Private Functions/Methods

        private void NextMenuPanel(GameObject menu)
        {
            _menuPanels[0].SetActive(false);
            _menuPanels.Insert(0, menu);
            _menuPanels[0].SetActive(true);
        }

        private void PreviousMenuPanel()
        {
            _menuPanels[0].SetActive(false);
            _menuPanels.RemoveAt(0);
            _menuPanels[0].SetActive(true);
        }

        #endregion

        #region Public Functions/Methods for use with Buttons

        public void StartGame()
        {
            NextMenuPanel(_gameSelection);
        }

        public void NewGame()
        {
            NextMenuPanel(_eggSelection);
        }

        public void BackButton()
        {
            PreviousMenuPanel();
        }

        public void ExitButton()
        {
            Application.Quit();
        }

        public void EggButton(int egg)
        {
            _egg = egg;
            NextMenuPanel(_nameSelection);
        }

        public void ConfirmButton()
        {
            _nameText.text = _nameInputField.text;
            _image.sprite = PlayerManager.Instance.Eggs[_egg].BibiSprite;
            NextMenuPanel(_confirmSelection);
        }

        public void YesButton()
        {
            PlayerManager.Instance.SpawnBibi();
            PlayerManager.Instance.PlayerBibi.BibiInit(PlayerManager.Instance.Eggs[_egg], _nameInputField.text);
            NextMenuPanel(_eggHatchingScreen);
            _gameScreen.SpawnEgg();
        }

        public void NoButton()
        {
            NextMenuPanel(_eggSelection);
        }

        #endregion
    }
}