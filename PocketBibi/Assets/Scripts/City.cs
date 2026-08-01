/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: City.cs
 * Date Created: July 31 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: July 31 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace PocketBibi
{
    public class City : MonoBehaviour
    {
        [SerializeField] private Image _bibi;
        [SerializeField] private Transform[] _buildingLocations;

        private void OnEnable()
        {
            if(PlayerManager.Instance.PlayerBibi.BibiSprite != null)
            {
                _bibi.sprite = PlayerManager.Instance.PlayerBibi.BibiSprite;
            }
        }

        public void _arcadeButton() { }
        public void _fishButton() { }
        public void _hotelButton() { }
        public void _infoButton() { }
        public void _restaurantButton() { }
        public void _schoolButton() { }
        public void _veggiesButton() { }
        public void _workButton() { }
    }
}