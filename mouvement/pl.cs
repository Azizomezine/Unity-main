using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teddy : MonoBehaviour
{
    public int rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(Vector3.up * Time.deltaTime * rotationSpeed);
    }
}
