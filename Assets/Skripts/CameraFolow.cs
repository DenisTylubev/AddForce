using UnityEngine;
using System.Collections;

public class CameraFolow : MonoBehaviour
{

    public GameObject player;        


    private Vector3 offset;            

   
    void Start()
    {
        UnityEngine.Cursor.visible = false;
        offset = transform.position - player.transform.position;
    }

  
    void LateUpdate()
    {
        
        transform.position = player.transform.position + offset;
    }
}