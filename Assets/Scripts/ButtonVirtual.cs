using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVirtual : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    public bool isSwitchedOn;
    public GameObject targetObject;
    public GameObject targetObject2;
    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            if (isSwitchedOn )
            {
                targetObject2.SetActive(false);
                targetObject.SetActive(true);
                isSwitchedOn = false;

            }
            else if (!isSwitchedOn)
            {
                targetObject.SetActive(false);
                targetObject2.SetActive(true);
                isSwitchedOn = true;
            }
            if (!isPressed)
            {
                button.transform.localPosition = new Vector3(0, -0.002f, 0);
                presser = other.gameObject;
                //isPressed = true;
            }
            Debug.Log(isSwitchedOn);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            if (other.gameObject == presser)
            {
                button.transform.localPosition = new Vector3(0, 0.0003f, 0);
                isPressed = false;
                //lightObject.enabled = false;
            }
        }
    }
    public bool SwitchedOn()
    {
        
        return isSwitchedOn;
    }
}
