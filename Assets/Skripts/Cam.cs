using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float MouseX;
    private float MouseY;
    [Header("Чуствительность Мыши ")]
    public float sensitiveMouse = 100f;
    public Transform Player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        MouseX = Input.GetAxis("Mouse X") * sensitiveMouse * Time.deltaTime;
        MouseY = Input.GetAxis("Mouse Y") * sensitiveMouse * Time.deltaTime;
        Player.Rotate(MouseX * new Vector3(0, 1, 0));
        transform.Rotate(-MouseY * new Vector3(1, 0, 0));

    }
}
