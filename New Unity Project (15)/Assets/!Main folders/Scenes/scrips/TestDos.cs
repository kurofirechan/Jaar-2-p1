using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDos : MonoBehaviour

{
    public float moveSpeed = 30;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Time.deltaTime * moveSpeed);
    }
}
