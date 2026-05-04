/***************************************************************************************
 *Copyright: Ninja Lady Game Development
 * Script: ItemData.cs
 * Date Created: April 22 2026
 * Created By: Richard Als
 * Description: ScriptableObject to hold default game information.
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: May 4 2026
 ****************************************************************************************
 * TODO: Only fish and veggie can be sold. Player can only buy food and toys.
 *Known Bugs:
****************************************************************************************/

using PocketBibi;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemConfig_", menuName = "ScriptableObjects/ItemConfig")]
public class ItemData : ScriptableObject
{
    #region Private Variables/Fields Exposed to Inspector for Editing

    [SerializeField] private ItemType _itemType = ItemType.Food;
    [SerializeField] private Sprite _itemSprite = null;
    [SerializeField] private string _itemName = null;
    [SerializeField] private int _buyingPrice = 0;
    [SerializeField] private int _sellingPrice = 0;
    [SerializeField] private int _stat = 0;
    [SerializeField] private bool _canBeSold = false;

    #endregion

    #region Public Getters/Accessors

    public ItemType eItemType => _itemType;
    public Sprite ItemSprite => _itemSprite;
    public string ItemName => _itemName;
    public int BuyingPrice => _buyingPrice;
    public int SellingPrice => _sellingPrice;
    public int Stat => _stat;
    public bool CanBeSold => _canBeSold;

    #endregion
}
