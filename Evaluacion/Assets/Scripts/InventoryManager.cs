using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    [SerializeField]
    GameObject inventory;           // Reference to the inventory
    [SerializeField]
    InventorySlot[] slots;          // Array to store all the inventory slots

    private InventorySlot slot;     // Variable to store one single slot

    private bool inventoryEnabled;  // Bool to check if inventory is displayed or not
    private int allSlots;           // Int which stores all the slots the inventory has
    private int enabledSlots;       // Int to know how many slots the player has available in the inventory
    private bool slotEnabled;       // Bool to check whether the slot is enabled or not
    private int slotIndex;          // Int that stores the array position of a slot

    public InventorySlot[] GetAllSlots() { return slots; }
    public InventorySlot GetSlot(int index) { return slots[index]; }

    public void MoveSlot(int index, int targetPosition) { }
    public void SellSlot(int index) { }
    public void BuySlot(int index) { }
    public void UseSlot(int index) { }

}
