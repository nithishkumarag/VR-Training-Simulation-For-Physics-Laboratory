using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour
{
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        Object.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Switch()
    {
        if (Object.activeSelf == false) Object.SetActive(true);
        else Object.SetActive(false);
    }
}
