using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D");
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            print("trigger");
        }
        else print("nesto");
    }
}
