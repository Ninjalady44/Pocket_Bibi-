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

        private LocationButtonOrder eBttnCurrent = LocationButtonOrder.Bedroom;
        private LocationButtonOrder eBttnUnused = LocationButtonOrder.Backyard;
        private RectTransform _currentLocationButton;
        private RectTransform _unusedButton;

        #endregion

        #region Private Functions/Methods

        private void OnEnable()
        {
            _currentLocationButton = _buttons[(int)eBttnCurrent];
            _buttons[(int)eBttnUnused].gameObject.SetActive(false);
        }

        private void OnDisable()
        {
            
        }

        #endregion

        #region Public Functions/Methods for use with Buttons

        public void BathroomButton()
        {
            eBttnCurrent = LocationButtonOrder.Bathroom;
        }

        public void BedroomButton()
        {
            eBttnCurrent = LocationButtonOrder.Bedroom;
        }

        public void LivingRoomButton()
        {
            eBttnCurrent = LocationButtonOrder.Livingroom;
        }
        
        public void KitchenRoonButton()
        {
            eBttnCurrent = LocationButtonOrder.Kitchen;
        }

        public void ForestButton()
        {
            eBttnCurrent = LocationButtonOrder.Forest;
        }

        public void CityButton() 
        {
            eBttnCurrent = LocationButtonOrder.City;
        }

        public void BeachButton()
        {
            eBttnCurrent = LocationButtonOrder.Beach;
        }

        public void RuinsButton()
        {
            eBttnCurrent = LocationButtonOrder.Ruins;
        }

        public void BackyardButton()
        {
            eBttnCurrent = LocationButtonOrder.Backyard;
        }

        public void ExitButton()
        {
            gameObject.SetActive(false);
            _gameScreen.InSideButton();
        }

        #endregion
    }
}