using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerMoney;
    public float playerSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Money")
        {
            playerMoney++; 
            Destroy(other.gameObject);
        }
    }

    private void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput);

        // Move the player
        transform.Translate(direction * (playerSpeed * Time.deltaTime));
    }
}
