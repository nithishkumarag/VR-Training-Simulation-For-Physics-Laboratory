using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject targetObject2;
    public LogicGateAnd logicGateAnd;


    public void Changed()
    {
        // Example condition to switch materials (can be any condition)
        if (logicGateAnd.IsChanged())
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
}
