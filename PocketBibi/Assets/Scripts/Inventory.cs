/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: Inventory.cs
 * Date Created: April 22 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: May 3 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace PocketBibi
{
    public class Inventory : MonoBehaviour
    {
        #region Private Variables/Fields Exposed to Inspector for Editing

        [SerializeField] private Button[] _inventorySlots = null;
        [SerializeField] private TextMeshProUGUI[] _itemAmountText = null;
        [SerializeField] private GameObject _upArrowBttn = null;
        [SerializeField] private GameObject _downArrowBttn = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private List<ItemData> _foodInventory;
        private List<ItemData> _fishInventory;
        private List<ItemData> _veggiesInventory;
        private List<ItemData> _toysInventory;
        private List<ItemData> _tresuresInventory;
        private List<ItemData> _currentInventory;
        private int _currentInventoryIndex;

        #endregion

        private void Start()
        {
            _fishInventory = new List<ItemData>();
            _toysInventory = new List<ItemData>();
            _foodInventory = new List<ItemData>();
            _tresuresInventory = new List<ItemData>();
            _veggiesInventory = new List<ItemData>();
            _currentInventoryIndex = 0;

            var temp = Resources.LoadAll<ItemData>("Data/Configs/FoodConfigs");

            for (int i = 0; i < temp.Length; i++)
            {
                _foodInventory.Add(temp[i]);
            }

            FoodButton();
        }

        public void AddItemToInventory(List<ItemData> inventory, ItemData item)
        {
            inventory.Add(item);
        }

        public void RemoveFromInventory()
        {

        }

        public void DisplayInventroy(List<ItemData> inventory)
        {
            for(int i = 0; i < _inventorySlots.Length; i++)
            {
                if(inventory.Count - 1 >= i && i + _currentInventoryIndex < inventory.Count)
                {
                    _inventorySlots[i].image.sprite = inventory[i + _currentInventoryIndex].ItemSprite;
                    _inventorySlots[i].gameObject.SetActive(true);
                }
                else
                {
                    _inventorySlots[i].gameObject.SetActive(false);
                }
            }

            ShowUpButton();
            ShowDownButton();
        }

        #region Public Functions/Methods for use with Buttons

        private void ShowUpButton()
        {
            _upArrowBttn.SetActive(_currentInventoryIndex >= 5);
        }

        private void ShowDownButton()
        {
            _downArrowBttn.SetActive(_currentInventoryIndex + 5 < _currentInventory.Count);
        }

        public void FoodButton()
        {
            _currentInventory = _foodInventory;
            DisplayInventroy(_currentInventory);
        }

        public void ToyButton()
        {
            _currentInventory = _toysInventory;
            DisplayInventroy(_currentInventory);
        }

        public void FishButton()
        {
            _currentInventory = _fishInventory;
            DisplayInventroy(_currentInventory);
        }

        public void TreasureButton()
        {
            _currentInventory = _tresuresInventory;
            DisplayInventroy(_currentInventory);
        }

        public void VeggiesButton()
        {
            _currentInventory = _veggiesInventory;
            DisplayInventroy(_currentInventory);
        }

        public void DownButton()
        {
            if(_currentInventoryIndex + 5 < _currentInventory.Count)
            {
                _currentInventoryIndex += 5;
            }

            DisplayInventroy(_currentInventory);
        }

        public void UpButton()
        {
            if (_currentInventoryIndex != 0)
            {
                _currentInventoryIndex -= 5;
            }

            DisplayInventroy(_currentInventory);
        }

        public void ItemButton(int buttonNumber)
        {
            for(int i = 0; i < _currentInventory.Count; i++)
            {
                if( _currentInventory[i].ItemSprite == _inventorySlots[buttonNumber].image.sprite)
                {
                    Debug.Log(_currentInventory[i].name);
                    break;
                }
            }
        }

        #endregion
    }
}
