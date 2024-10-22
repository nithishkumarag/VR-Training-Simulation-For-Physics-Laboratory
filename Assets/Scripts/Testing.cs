using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    private bool isTriggered = false; // Stores the current state of the trigger

    public bool IsTriggered()
    {
        return isTriggered;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("YourTriggerTag") || other.CompareTag("YourTriggerTag2"))
        {
            Debug.Log("Enter");
            isTriggered = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("YourTriggerTag") || other.CompareTag("YourTriggerTag2"))
        {
            Debug.Log("Enter");
            isTriggered = false;
        }
    }
}