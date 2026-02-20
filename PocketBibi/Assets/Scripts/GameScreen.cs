/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: GameScreen.cs
 * Date Created: February 06 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: February 06 2026
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
        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private GameObject[] _screens = null;
        [SerializeField] private Image _menuBG = null;
        [SerializeField] private Transform _eggSpawnLoc = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private GameObject _currentScreen;

        #endregion

        #region Public Functions/Methods

        public void Start()
        {
            foreach (var screen in _screens)
            {
                if(screen != _screens[0])
                {
                    screen.gameObject.SetActive(false);
                }
            }
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
            ChangeScreen(_screens[0]);
            _menuBG.enabled = false;
            gameObject.SetActive(true);
        }

        #endregion

        #region Public Functions/Methods for use with Buttons

        #endregion
    }
}