/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: GameScreen.cs
 * Date Created: February 06 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: March 17 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace PocketBibi
{
    public class GameScreen : MonoBehaviour
    {
        private readonly string BUTTONS_ON = "ButtonsOn";

        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private GameObject[] _screens = null;
        [SerializeField] private GameObject _locationMenu = null;
        [SerializeField] private GameObject _statusSettingButton = null;
        [SerializeField] private Image _menuBG = null;
        [SerializeField] private Transform _eggSpawnLoc = null;
        [SerializeField] private Animator _careButtonAnimator = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private GameObject _currentScreen;

        #endregion

        #region Public Getters/Accessors

        public GameObject[] Screens => _screens;

        #endregion

        #region Public Functions/Methods

        public void Start()
        {
            foreach (var screen in _screens)
            {
                if (screen != _screens[(int)GameScreens.EGG_HATCHING] && screen != _screens[(int)GameScreens.BEDROOM])
                {
                    screen.gameObject.SetActive(false);
                }
            }

            _screens[(int)GameScreens.BEDROOM].SetActive(true);
        }

        public void OnEnable()
        {
            Actions.evolveScreenFinished += FinishHatching;
        }

        public void OnDisable()
        {
            Actions.evolveScreenFinished -= FinishHatching;
        }

        public void ChangeScreen(GameObject screen)
        {
            if(_currentScreen != null)
            {
                _currentScreen.SetActive(false);
            }
            
            _currentScreen = screen;
            _currentScreen.SetActive(true);
        }

        public void SpawnEgg()
        {
            var player = PlayerManager.Instance.PlayerBibi;
            player.transform.position = _eggSpawnLoc.transform.position;
            player.gameObject.SetActive(true);
            ChangeScreen(_screens[(int)GameScreens.EGG_HATCHING]);
            _menuBG.enabled = false;
            gameObject.SetActive(true);
        }

        public void FinishHatching()
        {
            ChangeScreen(_screens[(int)GameScreens.HOME]);
            _careButtonAnimator.SetBool(BUTTONS_ON, true);
        }

        public void InSideButton()
        {
            _careButtonAnimator.SetBool(BUTTONS_ON, true);
        }

        #endregion

        #region Public Functions/Methods for use with Buttons

        public void OutSideButton()
        {
            _careButtonAnimator.SetBool(BUTTONS_ON, false);
            _locationMenu.SetActive(true);
        }

        public void StatusSettingsButton()
        {
            _careButtonAnimator.SetBool(BUTTONS_ON, false);
            _statusSettingButton.SetActive(true);
        }

        #endregion
    }
}