/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: ScreenManager.cs
 * Date Created: January 30 2026
 * Created By: Richard Als
 * Description: Handles switching the screens.
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: January 30 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using UnityEngine;

namespace PocketBibi
{
    public class ScreenManager : MonoBehaviour
    {
        #region Singleton
        private static ScreenManager _instance = null;
        public static ScreenManager Instance => _instance;
        #endregion

        #region Private Variables/Fields Exposed to Inspector for Editing
        [SerializeField] private GameObject[] _screens = null;
        #endregion

        #region Private Variables/Fields used in this Class Only

        private GameObject _currentScreen;

        #endregion

        #region Public Getters/Accessors

        public GameObject[] Screens => _screens;

        #endregion

        #region Private Initialization Functions/Methods
        private void Awake()
        {
            if(_instance != null &&  _instance != this)
            {
                Destroy(this.gameObject);
            }

            _instance = this;
        }

        private void Start()
        {
            _currentScreen = _screens[0];

            for (int i = 1; i < _screens.Length; i++)
            {
                _screens[i].SetActive(false);
            }
        }
        #endregion

        #region Public Functions/Methods
        public void ChangeScreen(GameObject screen)
        {
            _currentScreen.SetActive(false);
            _currentScreen = screen;
            _currentScreen.SetActive(true);
        }
        #endregion
    }
}
