/****************************************************************************************
 * Copyright: Ninja Lady Game Development
 * Script: Inventory.cs
 * Date Created: April 22 2026
 * Created By: Richard Als
 * Description: 
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: April 23 2026
 ****************************************************************************************
 * TODO: 
 * Known Bugs:
 ****************************************************************************************/

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PocketBibi
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private Button[] _inventorySlots = null;
        [SerializeField] private GameObject _upArrowBttn = null;
        [SerializeField] private GameObject _downArrowBttn = null;

        private List<ItemData> _foodInventory;
        private List<ItemData> _fishInventory;
        private List<ItemData> _veggiesInventory;
        private List<ItemData> _toysInventory;
        private List<ItemData> _tresuresInventory;

        private void Start()
        {
            _fishInventory = new List<ItemData>();
            _toysInventory = new List<ItemData>();
            _foodInventory = new List<ItemData>();
            _tresuresInventory = new List<ItemData>();
            _veggiesInventory = new List<ItemData>();
        }

        public void AddItemToInventory(List<ItemData> inventory, ItemData item)
        {
            inventory.Add(item);
        }

        public void DisplayInventroy(List<ItemData> inventory)
        {
            for(int i = 0; i < _inventorySlots.Length; i++)
            {
                if(inventory[i] != null)
                {
                    _inventorySlots[i].image.sprite = inventory[i].ItemSprite;
                    _inventorySlots[i].gameObject.SetActive(true);
                }
                else
                {
                    _inventorySlots[i].gameObject.SetActive(false);
                }
            }
        }

        public void FoodButton()
        {
            DisplayInventroy(_foodInventory);
        }

        public void ToyButton()
        {
            DisplayInventroy(_toysInventory);
        }

        public void FishButton()
        {
            DisplayInventroy(_fishInventory);
        }

        public void TreasureButton()
        {
            DisplayInventroy(_tresuresInventory);
        }

        public void VeggiesButton()
        {
            DisplayInventroy(_veggiesInventory);
        }
    }
}
