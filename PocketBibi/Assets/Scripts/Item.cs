/***************************************************************************************
 *Copyright: Ninja Lady Game Development
 * Script: Item.cs
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

namespace PocketBibi
{
    public abstract class Item
    {
        private const int MAX_ITEM_AMOUNT = 9;

        protected ItemData _itemConfig = null;
        protected int _itemAmount = 0;
        protected int _index = 0;

        public ItemData ItemConfig => _itemConfig;
        public int ItemAmount => _itemAmount;

        public Item(ItemData itemConfig) { _itemConfig = itemConfig; }
        public void AddItem() { _itemAmount += 1; if (_itemAmount > MAX_ITEM_AMOUNT) { _itemAmount = MAX_ITEM_AMOUNT; } }
        public void RemoveItem() { _itemAmount -= 1; if (_itemAmount < 0) { _itemAmount = 0; } }
        abstract public void Use();
    }
}