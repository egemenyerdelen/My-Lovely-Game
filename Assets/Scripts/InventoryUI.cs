using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    
    private Inventory _inventory;
    private InventorySlot[] _slots;

    void Start()
    {
        _inventory = Inventory.Instance;
        _inventory.OnItemChangedCallback += UpdateUI;

        _slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateUI()
    {
        for (int i = 0; i < _slots.Length; i++)
        {
            if (i < _inventory.items.Count)
            {
                _slots[i].AddItem(_inventory.items[i]);
            }
            else
            {
                _slots[i].ClearSlot();
            }
        }
    }
}
