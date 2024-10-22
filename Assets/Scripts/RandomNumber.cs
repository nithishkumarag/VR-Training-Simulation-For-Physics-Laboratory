//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNumber : MonoBehaviour
{
    //[SerializeField]float number;
    [SerializeField] float random;
    [SerializeField] TMP_Text displayNumber;
    [SerializeField] TMP_Text displayNumber2;
    // Start is called before the first frame update
    void Update()
    {
        GameObject myObject = GameObject.Find("MyObject");

        // Check if the object was found
        if (myObject != null)
        {
            // Get the position of the object
            Vector3 position = myObject.transform.position;

            // Convert the position to floats with three decimal points
            float x = Mathf.Round(position.x * 1000f) / 1000f;
            float y = Mathf.Round(position.y * 1000f) / 1000f;
            float z = Mathf.Round(position.z * 1000f) / 1000f;
            x = (int)(x * 1000);

            // Print the position to the console
            //Debug.Log("Object position: (" + x + ", " + y + ", " + z + ")");
            UpdateNumber(x%1000);
        }
    }

    // Update is called once per frame
   // void Update()
   // {
    //    UpdateNumber();
        
   // }

    private void UpdateNumber(float number)
    {
        random = number/1000;
        displayNumber.text = random.ToString("0.###");
        displayNumber2.text = (random * 2).ToString("0.###");

    }
}
