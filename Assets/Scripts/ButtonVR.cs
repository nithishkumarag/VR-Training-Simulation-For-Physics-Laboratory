using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    public Light lightObject;
    public bool isSwitchedOn;
    public TriggerManager triggerManager;
    public bool trigger = false;
    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
        
        lightObject.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        trigger = triggerManager.Triggered();
        if (!isSwitchedOn && trigger)
        {
            isSwitchedOn = true;
            lightObject.enabled = isSwitchedOn;
        }
        else if (isSwitchedOn)
        {
            isSwitchedOn = false;
            lightObject.enabled = isSwitchedOn;
        }
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, -0.002f, 0);
            presser = other.gameObject;
            //isPressed = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.0003f, 0);
            isPressed = false;
            //lightObject.enabled = false;
        }
    }
    public bool SwitchedOn()
    {
        return isSwitchedOn;
    }
 

}
