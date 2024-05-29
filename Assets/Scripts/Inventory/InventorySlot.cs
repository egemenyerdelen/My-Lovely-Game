using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Button removeButton;
    
    private Item _item;

    public void AddItem(Item newItem)
    {
        _item = newItem;

        icon.sprite = _item.icon;
        icon.enabled = true;

        removeButton.interactable = true;
    }

    public void ClearSlot()
    {
        _item = null;

        icon.sprite = null;
        icon.enabled = false;

        removeButton.interactable = false;
    }

    public void OnRemoveButton()
    {
        Inventory.Instance.Remove(_item);
    }

    public void UseItem()
    {
        if (_item != null)
        {
            _item.Use();
        }
    }
}
