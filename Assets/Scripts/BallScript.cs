using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody _rb;

    float speed = 10;

    public Vector3 tilt;
    private void keyMovement()
    {
        // moving the ball with the keyboard was required for debuging and testing on a desktop PC
        if (Input.GetKeyDown(KeyCode.W))
        {
            _rb.AddForce(transform.forward * 50, ForceMode.Acceleration);
            Debug.Log("W key pressed");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _rb.AddForce(transform.right * 50, ForceMode.Acceleration);
            Debug.Log("D key pressed");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            _rb.AddForce(-transform.right * 50, ForceMode.Acceleration);
            Debug.Log("A key pressed");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _rb.AddForce(-transform.forward * 50, ForceMode.Acceleration);
            Debug.Log("S key pressed");
        }
    }

    Gyroscope gyro;
    Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        transform.SetParent(null);
        /*
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            transform.parent.transform.rotation = Quaternion.Euler(90, 90, 0);
            rot = new Quaternion(0, 0, 1, 0);
        }*/
    }


    // Update is called once per frame
    void Update()
    {
        keyMovement();
        tilt = Input.acceleration;
        
        _rb.AddForce(tilt * speed);
    }
}
