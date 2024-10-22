using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicGateNot : MonoBehaviour
{
    public GameObject trigger1;// Reference to the first trigger object (e.g., cube)
    public ButtonVirtual buttonVirtual1;
    public ButtonVirtual buttonVirtual2;

    private bool triggered;
    private void Start()
    {
        triggered = false;
    }

    void Update()
    {
        // Use a separate variable to store the combined state
        bool bothActive = GetCombinedState();
        Changed();

        // Update a designated object's material based on the combined state
    }

    public bool GetCombinedState()
    {
        // Access the TriggerScript components of both triggers
        TestingNot script1 = trigger1.GetComponent<TestingNot>();

        triggered = script1.IsTriggered();
        //Debug.Log(triggered);
        // Check if both trigger scripts report their triggers as active
        return triggered;
    }
    public bool IsChanged()
    {
        if (!(buttonVirtual1.SwitchedOn()))
        {
            return true;
        }
        return false;
    }
    public GameObject targetObject;
    public GameObject targetObject2;


    public void Changed()
    {
        // Example condition to switch materials (can be any condition)
        if (triggered)
        {
            if (IsChanged())
            {
                targetObject.SetActive(false);
                targetObject2.SetActive(true);
            }
            else
            {
                targetObject2.SetActive(false);
                targetObject.SetActive(true);
            }
        }
        else
        {
            targetObject.SetActive(true);
            targetObject2.SetActive(false);
        }
    }

}
