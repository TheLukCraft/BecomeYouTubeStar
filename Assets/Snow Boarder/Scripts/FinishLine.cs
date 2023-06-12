using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UnityEngine.Debug.Log("You finished!");
        }
    }
}
