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
        [SerializeField] private InfoWindow _infoWindow = null;
        [SerializeField] private GameScreen _gameScreen = null;

        #endregion

        #region Private Variables/Fields used in this Class Only

        private List<Item> _foodInventory;
        private List<Item> _fishInventory;
        private List<Item> _veggiesInventory;
        private List<Item> _toysInventory;
        private List<Item> _tresuresInventory;
        private List<Item> _currentInventory;
        private int _currentInventoryIndex;

        #endregion

        public List<Item> FoodInventory => _foodInventory;

        #region Private Initialization Functions/Methods

        private void Start()
        {
            _fishInventory = new List<Item>();
            _toysInventory = new List<Item>();
            _foodInventory = new List<Item>();
            _tresuresInventory = new List<Item>();
            _veggiesInventory = new List<Item>();
            _currentInventoryIndex = 0;

            var temp = Resources.LoadAll<ItemData>("Data/Configs/FoodConfigs");

            for (int i = 0; i < temp.Length; i++)
            {
                var item = new FoodItem(temp[i]);
                item.AddItem();
                _foodInventory.Add(item);
            }

            FoodButton();
        }

        #endregion

        #region Public Functions/Methods

        public void AddItemToInventory(List<Item> inventory, Item item)
        {
            inventory.Add(item);
        }

        public void RemoveFromInventory(List<Item> inventory, Item item)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].ItemConfig.name == item.ItemConfig.name)
                {
                    inventory.RemoveAt(i);
                    break;
                }
            }

            DisplayInventroy(inventory);
        }

        public void DisplayInventroy(List<Item> inventory)
        {
            for (int i = 0; i < _inventorySlots.Length; i++)
            {
                if (inventory.Count - 1 >= i && i + _currentInventoryIndex < inventory.Count)
                {
                    _inventorySlots[i].image.sprite = inventory[i + _currentInventoryIndex].ItemConfig.ItemSprite;
                    _itemAmountText[i].text = inventory[i].ItemAmount.ToString();
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

        private void ShowUpButton()
        {
            _upArrowBttn.SetActive(_currentInventoryIndex >= 5);
        }

        private void ShowDownButton()
        {
            _downArrowBttn.SetActive(_currentInventoryIndex + 5 < _currentInventory.Count);
        }

        #endregion

        #region Public Functions/Methods for use with Buttons

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
                if( _currentInventory[i].ItemConfig.ItemSprite == _inventorySlots[buttonNumber].image.sprite)
                {
                    //Debug.Log(_currentInventory[i].ItemConfig.name);
                    _infoWindow.DisplayItemInfo(_currentInventory[i].ItemConfig.ItemSprite, _currentInventory[i].ItemConfig.ItemName, "", _currentInventory[i], 
                        _currentInventory[i].ItemAmount);
                    break;
                }
            }
        }

        public void ExitButton()
        {
            gameObject.SetActive(false);
            _gameScreen.InSideButton();
        }

        #endregion
    }
}
