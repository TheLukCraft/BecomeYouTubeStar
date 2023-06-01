using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        UnityEngine.Debug.Log("Ouch!");
    }
}
