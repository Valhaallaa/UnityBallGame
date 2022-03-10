using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadWall : MonoBehaviour
{
    
    GameObject Ball;
    void OnCollisionEnter(Collision other)
    {
        // if a gameobject containing the letters 'all' collides with whatever object this script is on it will be deleted, in this case the ball
        if (other.gameObject.name.Contains("all"))
        {
            
            Destroy(other.gameObject);
    
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
