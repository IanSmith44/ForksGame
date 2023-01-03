using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    Vector2 movement;
    public Camera mainCam;
    public List<string> usedRooms = new List<string>();

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * moveSpeed);

        if (transform.position.x > -26.7f && transform.position.x < -8.9f)
        {
            mainCam.transform.position = new Vector3(-17.8f, mainCam.transform.position.y, mainCam.transform.position.z);
            if (transform.position.y > -5 && transform.position.y < 5)
            {
                Debug.Log("test");
            }
        }
        else if (transform.position.x > -8.9f && transform.position.x < 8.9f)
        {
            mainCam.transform.position = new Vector3(0, mainCam.transform.position.y, mainCam.transform.position.z);
        }
        else if (transform.position.x > 8.9f && transform.position.x < 26.7f)
        {
            mainCam.transform.position = new Vector3(17.8f, mainCam.transform.position.y, mainCam.transform.position.z);
        }
        else if (transform.position.x > 26.7f && transform.position.x < 44.5f)
        {
            mainCam.transform.position = new Vector3(35.6f, mainCam.transform.position.y, mainCam.transform.position.z);
        }
        else if (transform.position.x > 44.5f && transform.position.x < 62.3f)
        {
            mainCam.transform.position = new Vector3(53.4f, mainCam.transform.position.y, mainCam.transform.position.z);
        }

        if (transform.position.y > 5 && transform.position.y < 15)
        {
            mainCam.transform.position = new Vector3(mainCam.transform.position.x, 10, mainCam.transform.position.z);
        }
        else if (transform.position.y > -5 && transform.position.y < 5)
        {
            mainCam.transform.position = new Vector3 (mainCam.transform.position.x, 0, mainCam.transform.position.z);
        }
        else if (transform.position.y < -5)
        {
            mainCam.transform.position = new Vector3(mainCam.transform.position.x, -10, mainCam.transform.position.z);
        }
    }
}

