using UnityEngine;

public class Interactable : MonoBehaviour
{ 
    [SerializeField] private float radius = 3f;
    [SerializeField] private Transform interactionTransform;
    
    private GameObject _playerGameObject;

    private void Start()
    {
        _playerGameObject = FindObjectOfType<PlayerController>().gameObject;
        if (interactionTransform == null)
        {
            interactionTransform = transform;
        }
    }

    private void Update()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        // This method is meant to be overwritten
        var isInRadius = Vector2.Distance(_playerGameObject.transform.position, interactionTransform.position) <= radius;
        if (Input.GetKeyDown(KeyCode.E) && isInRadius)
        {
            Debug.Log("Interacted with " + transform.name);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}
