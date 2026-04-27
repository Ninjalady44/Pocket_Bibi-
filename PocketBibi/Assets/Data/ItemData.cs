/***************************************************************************************
 *Copyright: Ninja Lady Game Development
 * Script: ItemData.cs
 * Date Created: April 22 2026
 * Created By: Richard Als
 * Description: ScriptableObject to hold default game information.
 ****************************************************************************************
 * Modified By: Richard Als
 * Date Last Modified: April 22 2026
 ****************************************************************************************
 * TODO: 
 *Known Bugs:
****************************************************************************************/

using UnityEngine;

[CreateAssetMenu(fileName = "ItemConfig", menuName = "ScriptableObjects/ItemConfig")]
public class ItemData : ScriptableObject
{
    [SerializeField] private Sprite _itemSprite = null;
    [SerializeField] private string _itemName = null;
    [SerializeField] private int _buyingPrice = 0;
    [SerializeField] private int _sellingPrice = 0;

    public Sprite ItemSprite => _itemSprite;
    public string ItemName => _itemName;
    public int BuyingPrice => _buyingPrice;
    public int sellingPrice => _sellingPrice;
}
