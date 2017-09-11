using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    void Awake()
    {

    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 20.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 20.0f;

        transform.Translate(-z, 0, 0);
        transform.Translate(0, 0, x);
    }
}
