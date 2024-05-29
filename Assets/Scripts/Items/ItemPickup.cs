using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
    public override void Interact()
    {
        base.Interact();
        if (Input.GetKeyDown(KeyCode.E) && IsInRadius)
        {
            PickUp();
        }
    }

    private void PickUp()
    {
        Debug.Log($"Picking up {item.name}");
        var wasPickedUp = Inventory.Instance.Add(item);

        if (wasPickedUp)
        {
            Destroy(gameObject);
        }
    }
}
