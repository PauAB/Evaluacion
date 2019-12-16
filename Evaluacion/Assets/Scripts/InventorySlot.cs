using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot {

    public float priceToBuy;       // Float to set the item buy price
    public float priceToSell;      // Float to set the item sell price
    public float slotCooldown;     // Usable slot cooldown as float
    public bool slotSelected;      // Bool to check wheter the slot is selected or not
    private bool slotBuyable;       // Bool to know if the slot can be bought
    private bool slotSellable;      // Bool to know if the slot can be sold
    private bool slotUsable;        // Bool to know if the slot can be used
    public bool slotBought;        // Bool to trigger an event when the slot is bought
    public bool slotSold;          // Bool to trigger an event when the slot is sold
    public bool slotUsed;          // Bool to trigger an event when the slot is used

    public bool IsSellable(int index) { return slotSellable; }
    public bool IsBuyable(int index) { return slotBuyable; }
    public bool IsUsable(int index) { return slotUsable; }

}
