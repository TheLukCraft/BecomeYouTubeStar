using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        UnityEngine.Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        UnityEngine.Debug.Log("What was that");
    }
}
