using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWallScript : MonoBehaviour
{
    [SerializeField]
    GameObject Wall;
    void OnCollisionEnter(Collision other)
    {
        //destroys the object the script is located on and a secondry object call wall aswell.
        if (other.gameObject.name.Contains("all"))
        {
            Destroy(gameObject);
            Destroy(Wall);
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
