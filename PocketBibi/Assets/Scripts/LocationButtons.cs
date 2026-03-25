/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: LocationButtons.cs
 * Date Created: March 8 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: March 8 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using UnityEngine;

namespace PocketBibi
{
    public class LocationButtons : MonoBehaviour
    {
        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private RectTransform[] _buttons = null;
        [SerializeField] private GameScreen _gameScreen = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private enum LocationButtonOrder 
        { 
            Bathroom,
            Bedroom,
            Livingroom,
            Kitchen,
            Forest,
            City,
            Beach,
            Ruins,
            Backyard,
            Exit
        }

        private LocationButtonOrder _eBttnCurrent = LocationButtonOrder.Bedroom;
        private LocationButtonOrder _eBttnUnused = LocationButtonOrder.Backyard;
        private RectTransform _currentLocationButton;
        private RectTransform _unusedButton;

        #endregion

        #region Private Functions/Methods

        private void OnEnable()
        {
            _currentLocationButton = _buttons[(int)_eBttnCurrent];
            _buttons[(int)_eBttnUnused].gameObject.SetActive(false);
        }

        #endregion

        #region Public Functions/Methods for use with Buttons

        public void BathroomButton()
        {
            _eBttnCurrent = LocationButtonOrder.Bathroom;
            _currentLocationButton = _buttons[(int)_eBttnCurrent];
            
            _currentLocationButton.gameObject.SetActive(false);
            _unusedButton = _buttons[(int)_eBttnUnused];
            _unusedButton.transform.localPosition = _currentLocationButton.transform.localPosition;
            _unusedButton.gameObject.SetActive(true);
            _eBttnUnused = _eBttnCurrent;
            _unusedButton = _buttons[(int)_eBttnCurrent];

            _gameScreen.ChangeScreen(_gameScreen.Screens[(int)GameScreens.BATHROOM]);

            gameObject.SetActive(false);
            _gameScreen.InSideButton();
        }

        public void BedroomButton()
        {
            _eBttnCurrent = LocationButtonOrder.Bedroom;
            _currentLocationButton = _buttons[(int)_eBttnCurrent];

            _currentLocationButton.gameObject.SetActive(false);
            _unusedButton = _buttons[(int)_eBttnUnused];
            _unusedButton.transform.localPosition = _currentLocationButton.transform.localPosition;
            _unusedButton.gameObject.SetActive(true);
            _eBttnUnused = _eBttnCurrent;
            _unusedButton = _buttons[(int)_eBttnCurrent];

            _gameScreen.ChangeScreen(_gameScreen.Screens[(int)GameScreens.BEDROOM]);

            gameObject.SetActive(false);
            _gameScreen.InSideButton();
        }

        public void LivingRoomButton()
        {
            _eBttnCurrent = LocationButtonOrder.Livingroom;
            _currentLocationButton = _buttons[(int)_eBttnCurrent];

            _currentLocationButton.gameObject.SetActive(false);
            _unusedButton = _buttons[(int)_eBttnUnused];
            _unusedButton.transform.localPosition = _currentLocationButton.transform.localPosition;
            _unusedButton.gameObject.SetActive(true);
            _eBttnUnused = _eBttnCurrent;
            _unusedButton = _buttons[(int)_eBttnCurrent];

            _gameScreen.ChangeScreen(_gameScreen.Screens[(int)GameScreens.LIVINGROOM]);

            gameObject.SetActive(false);
            _gameScreen.InSideButton();
        }
        
        public void KitchenRoonButton()
        {
            _eBttnCurrent = LocationButtonOrder.Kitchen;
            _currentLocationButton = _buttons[(int)_eBttnCurrent];

            _currentLocationButton.gameObject.SetActive(false);
            _unusedButton = _buttons[(int)_eBttnUnused];
            _unusedButton.transform.localPosition = _currentLocationButton.transform.localPosition;
            _unusedButton.gameObject.SetActive(true);
            _eBttnUnused = _eBttnCurrent;
            _unusedButton = _buttons[(int)_eBttnCurrent];

            _gameScreen.ChangeScreen(_gameScreen.Screens[(int)GameScreens.KITCHEN]);

            gameObject.SetActive(false);
            _gameScreen.InSideButton();
        }

        public void ForestButton()
        {
            _eBttnCurrent = LocationButtonOrder.Forest;
            _currentLocationButton = _buttons[(int)_eBttnCurrent];

            _currentLocationButton.gameObject.SetActive(false);
            _unusedButton = _buttons[(int)_eBttnUnused];
            _unusedButton.transform.localPosition = _currentLocationButton.transform.localPosition;
            _unusedButton.gameObject.SetActive(true);
            _eBttnUnused = _eBttnCurrent;
            _unusedButton = _buttons[(int)_eBttnCurrent];

            _gameScreen.ChangeScreen(_gameScreen.Screens[(int)GameScreens.FOREST]);
        }

        public void CityButton() 
        {
            _eBttnCurrent = LocationButtonOrder.City;
            _currentLocationButton = _buttons[(int)_eBttnCurrent];

            _currentLocationButton.gameObject.SetActive(false);
            _unusedButton = _buttons[(int)_eBttnUnused];
            _unusedButton.transform.localPosition = _currentLocationButton.transform.localPosition;
            _unusedButton.gameObject.SetActive(true);
            _eBttnUnused = _eBttnCurrent;
            _unusedButton = _buttons[(int)_eBttnCurrent];

            _gameScreen.ChangeScreen(_gameScreen.Screens[(int)GameScreens.CITY]);
        }

        public void BeachButton()
        {
            _eBttnCurrent = LocationButtonOrder.Beach;
            _currentLocationButton = _buttons[(int)_eBttnCurrent];

            _currentLocationButton.gameObject.SetActive(false);
            _unusedButton = _buttons[(int)_eBttnUnused];
            _unusedButton.transform.localPosition = _currentLocationButton.transform.localPosition;
            _unusedButton.gameObject.SetActive(true);
            _eBttnUnused = _eBttnCurrent;
            _unusedButton = _buttons[(int)_eBttnCurrent];

            _gameScreen.ChangeScreen(_gameScreen.Screens[(int)GameScreens.BEACH]);
        }

        public void RuinsButton()
        {
            _eBttnCurrent = LocationButtonOrder.Ruins;
            _currentLocationButton = _buttons[(int)_eBttnCurrent];

            _currentLocationButton.gameObject.SetActive(false);
            _unusedButton = _buttons[(int)_eBttnUnused];
            _unusedButton.transform.localPosition = _currentLocationButton.transform.localPosition;
            _unusedButton.gameObject.SetActive(true);
            _eBttnUnused = _eBttnCurrent;
            _unusedButton = _buttons[(int)_eBttnCurrent];

            _gameScreen.ChangeScreen(_gameScreen.Screens[(int)GameScreens.RUINS]);
        }

        public void BackyardButton()
        {
            _eBttnCurrent = LocationButtonOrder.Backyard;
            _currentLocationButton = _buttons[(int)_eBttnCurrent];

            _currentLocationButton.gameObject.SetActive(false);
            _unusedButton = _buttons[(int)_eBttnUnused];
            _unusedButton.transform.localPosition = _currentLocationButton.transform.localPosition;
            _unusedButton.gameObject.SetActive(true);
            _eBttnUnused = _eBttnCurrent;
            _unusedButton = _buttons[(int)_eBttnCurrent];

            _gameScreen.ChangeScreen(_gameScreen.Screens[(int)GameScreens.BACKYARD]);

            gameObject.SetActive(false);
            _gameScreen.InSideButton();
        }

        public void ExitButton()
        {
            gameObject.SetActive(false);
            _gameScreen.InSideButton();
        }

        #endregion
    }
}