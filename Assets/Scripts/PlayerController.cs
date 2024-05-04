using UnityEngine;
using Input = UnityEngine.Input;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5f;

    private Rigidbody2D playerRb;
    
    // Start is called before the first frame update
    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        var direction = new Vector3(horizontalInput, verticalInput);

        // Move the player
        playerRb.velocity = new Vector2(direction.x, direction.y) * playerSpeed;
    }
}
