using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected bool IsInRadius;
    
    [SerializeField] private float radius = 1f;
    [SerializeField] private Transform customInteractionPoint;
    [SerializeField] private GameObject playerGameObject;
    private Transform InteractionPoint => customInteractionPoint != null ? customInteractionPoint : transform;

    private void Update()
    {
        Interact();
    }

    public virtual void Interact()
    {
        // This method is meant to be overwritten
        IsInRadius = Vector2.Distance(playerGameObject.transform.position, InteractionPoint.position) <= radius;
        if (Input.GetKeyDown(KeyCode.E) && IsInRadius)
        {
            Debug.Log("Interacted with " + transform.name);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(InteractionPoint.position, radius);
    }
}
