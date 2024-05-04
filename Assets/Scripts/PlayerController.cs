using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5f;

    private Rigidbody2D _playerRb;
    
    private void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
    }
    
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
        _playerRb.velocity = new Vector2(direction.x, direction.y) * playerSpeed;
    }
}
