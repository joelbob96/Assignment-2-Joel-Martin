﻿using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static float speed = 800.0f;
    public Text scoreText;
    public Text winText;
    private int count = 0;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            scoreText.text = "Score: " + count;
            if(count >= 15)
            {
                winText.gameObject.SetActive(true);
            }
        }
    }

    public void changeSpeed(float newSpeed)
    {
        speed = newSpeed * 100;
    }
}
