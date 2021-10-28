using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSan : MonoBehaviour
{

    public float Mousesence = 100f;
    float xRotation = 0f;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Mousesence * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Mousesence * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Vector3 rot = new Vector3(0, mouseX, 0);
        Player.Rotate(rot);

    }
}
