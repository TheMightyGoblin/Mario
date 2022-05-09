using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leave : MonoBehaviour
{
    [SerializeField]GameObject vine;
    bool wasActivated = false;
    void Start() 
    {
        vine.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player" && !wasActivated)
        {
            wasActivated = true;
            vine.SetActive(true);
        }
    }
}
