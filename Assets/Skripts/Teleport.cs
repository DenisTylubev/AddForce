using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform posithion;
    public GameObject obj;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position =  posithion.transform.position;
    }
}
