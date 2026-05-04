/***************************************************************************************
 *Copyright: Ninja Lady Game Development
 * Script: FoodItem.cs
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
    public class FoodItem : Item
    {
        public FoodItem(ItemData itemConfig) : base(itemConfig) { }

        public override void Use()
        {
            RemoveItem();
            if(_itemAmount < 1)
            {
                PlayerManager.Instance.Inventory.RemoveFromInventory(PlayerManager.Instance.Inventory.FoodInventory, this);
            }

            //UnityEngine.Debug.Log("used item");
        }
    }
}