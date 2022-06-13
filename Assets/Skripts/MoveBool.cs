using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBool : MonoBehaviour
{
    private Rigidbody _RigiBoody;
    public float spead;
    void Awake()
    {
        _RigiBoody = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        if(Input.GetKey (KeyCode.W))
        {
            _RigiBoody.AddForce(0, 0, spead);

        }
        if (Input.GetKey(KeyCode.S))
        {
           _RigiBoody.AddForce(0, 0, -spead);
           
            

        }
        if (Input.GetKey(KeyCode.A))
        {
            _RigiBoody.AddForce(-spead, 0, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            _RigiBoody.AddForce(spead, 0, 0);

        }
        
    }
}
