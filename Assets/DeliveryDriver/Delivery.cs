using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D other)
    {
        UnityEngine.Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            UnityEngine.Debug.Log("Package picked up!");
            hasPackage = true;
        }
        if (other.tag == "Customer" && hasPackage)
        {
            UnityEngine.Debug.Log("Package delivered!");
            hasPackage = false;
        }
    }
}
