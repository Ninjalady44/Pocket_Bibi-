/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: SplashScreen.cs
 * Date Created: January 30 2026
 * Created By: Richard Als
 * Description: Just a timer to switch off the splash screen
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
    public class SplashScreen : MonoBehaviour
    {
        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private GameData _gameConfig = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private float _timer;

        #endregion

        #region Private Initialization Functions/Methods

        void Start()
        {
            _timer = _gameConfig.SplashScreenTimer;
        }

        #endregion

        #region Public Functions/Methods

        void Update()
        {
            _timer -= Time.deltaTime;

            if( _timer <= 0)
            {
                _timer = _gameConfig.SplashScreenTimer;
                PocketBibi.ScreenManager.Instance.ChangeScreen(PocketBibi.ScreenManager.Instance.Screens[(int)PocketBibi.Screen.MENU]);
            }
        }

        #endregion
    }
}