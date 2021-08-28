﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    Rigidbody rb;
    AudioSource audio;
    [SerializeField]
    float thrust;
    [SerializeField]
    float rotateThrust;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RocketFly();
        RocketControls();
    }
    private void RocketFly()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddRelativeForce(Vector3.up*thrust);
            if (audio.isPlaying == false)
            {
                audio.Play();
            }
        }
        else
        {
            audio.Stop();
        }
    }
    private void RocketControls()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotateThrust * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * rotateThrust * Time.deltaTime);
        }
    }
}
