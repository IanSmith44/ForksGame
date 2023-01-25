using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum enemyState
    {
        Idle,
        Agro

    }
    public PlayerMovement playerMovement;
    public float agroDistance = 5f;
    public float torque = 5f;
    public enemyState State;
    public float speed = 5f;
    public Transform player;
    public Rigidbody2D rb;
    public string currentRoom;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.currentRoom == "Sewers" || playerMovement.currentRoom == "Tunnel" || playerMovement.currentRoom == "Fork Factory")
        {
            State = enemyState.Agro;
        }
        else if (playerMovement.currentRoom == currentRoom)
        {
            State = enemyState.Agro;
        }
        else
        {
            State = enemyState.Idle;
        }
        if (transform.position.x > -26.7f && transform.position.x < -8.9f)
        {
            if (transform.position.y > -5 && transform.position.y < 5)
            {
                currentRoom = "Kitchen";
            }
        }
        else if (transform.position.x > -8.9f && transform.position.x < 8.9f)
        {
            if (transform.position.y > -5 && transform.position.y < 5)
            {
                currentRoom = "Living Room";
            }
            else if (transform.position.y > 5 && transform.position.y < 15)
            {
                currentRoom = "Garage";
            }
            else if (transform.position.y > -15 && transform.position.y < -5)
            {
                currentRoom = "Sewers";
            }
        }
        else if (transform.position.x > 8.9f && transform.position.x < 26.7f)
        {
            if (transform.position.y > -5 && transform.position.y < 5)
            {
                currentRoom = "Doorway";
            }
            else if (transform.position.y > -15 && transform.position.y < -5)
            {

            currentRoom = "Tunnel";

            }
        }
        else if (transform.position.x > 26.7f && transform.position.x < 44.5f)
        {
            if (transform.position.y > -5 && transform.position.y < 5)
            {
                currentRoom = "Front Yard";
            }
            else if (transform.position.y > -15 && transform.position.y < -5)
            {
                currentRoom = "Fork Factory";
            }
            else if (transform.position.y > -25 && transform.position.y < -15)
            {
                currentRoom = "Factory Road";
            }
            else if (transform.position.y > -35 && transform.position.y < -25)
            {
                currentRoom = "Metal Factory";
            }
        }
        else if (transform.position.x > 44.5f && transform.position.x < 62.3f)
        {
            if (transform.position.y > -5 && transform.position.y < 5)
            {
                currentRoom = "Northern Road";
            }
            else if (transform.position.y > -15 && transform.position.y < -5)
            {
                currentRoom = "Middle Road";
            }
            else if (transform.position.y > -25 && transform.position.y < -15)
            {
                currentRoom = "Southern Road";
            }
            else if (transform.position.y > -35 && transform.position.y < -25)
            {
                currentRoom = "Store";
            }
        }
    }
    void FixedUpdate()
    {
        if (State == enemyState.Agro)
        {
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Debug.Log(torque);
            if(rb.angularVelocity > -1500f)
            {
                rb.AddTorque(torque);
            }
            //rb.rotation = angle - 90f;
            rb.AddForce(direction.normalized * speed);
        }
    }
}
