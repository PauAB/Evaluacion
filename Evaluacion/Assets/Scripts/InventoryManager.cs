using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    [SerializeField]
    GameObject inventory;
    private GameObject[] slots;

    private bool inventoryEnabled;
    private int allSlots;    
    private int enabledSlots;
    private bool slotEnabled;
}
