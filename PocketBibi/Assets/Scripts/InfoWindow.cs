/***************************************************************************************
 *Copyright: Ninja Lady Game Development
 * Script: InfoWindow.cs
 * Date Created: May 4 2026
 * Created By: Richard Als
 * Description:
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: May 4 2026
 ****************************************************************************************
 * TODO: 
 *Known Bugs:
****************************************************************************************/

using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace PocketBibi
{
    public class InfoWindow : MonoBehaviour
    {
        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private Image _itemImage = null;
        [SerializeField] private TextMeshProUGUI _itemName = null;
        [SerializeField] private TextMeshProUGUI _itemDescription = null;
        [SerializeField] private TextMeshProUGUI _itemAmount = null;
        [SerializeField] private Button _useButton = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private Item _item;

        #endregion

        #region Private Initialization Functions/Methods

        private void Start()
        {
            gameObject.SetActive(false);
        }

        #endregion

        #region Public Functions/Methods

        public void DisplayItemInfo(Sprite sprite, string name, string description, Item item, int itemAmount)
        {
            _itemImage.sprite = sprite;
            _itemName.text = name;
            _itemDescription.text = description;
            _itemAmount.text = "X" + itemAmount;
            _item = item;
            gameObject.SetActive(true);
        }

        #endregion

        #region Public Functions/Methods for use with Buttons

        public void BackButton()
        {
            gameObject.SetActive(false);
        }

        public void UseButton()
        {
            _item.Use();
            gameObject.SetActive(false);
        }

        #endregion
    }
}