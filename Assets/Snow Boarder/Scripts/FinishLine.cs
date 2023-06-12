using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Invoke(ReloadScene, loadDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }
}
