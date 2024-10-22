using UnityEngine;
using TMPro;
using System.Collections.Generic;


public class TriggerManager : MonoBehaviour
{
    public List<GameObject> triggerPoints;
    private List<bool> triggeredStatus;
    private bool allTriggered = false;
    public TextMeshProUGUI messageText;
    public TextMeshProUGUI displayNumber;
    public TextMeshProUGUI displayNumber2;
    public ButtonVR buttonVR;


    void Start()
    {
        triggeredStatus = new List<bool>();
        foreach (var triggerPoint in triggerPoints)
        {
            triggeredStatus.Add(false);
        }
        Debug.Log(triggerPoints.Count);
        messageText.enabled = false; // Hide text initially
        displayNumber.enabled = false;
        displayNumber2.enabled = false;
    }

    void Update()
    {
        //if (!allTriggered)
        //{
        UpdateTriggeredStatus();
        CheckAllTriggered();
        //}
    }

    void UpdateTriggeredStatus()
    {
        for (int i = 0; i < triggerPoints.Count; i++)
        {
            if (triggerPoints[i].GetComponent<YourTriggerPointScript>().IsTriggered())
            {
                triggeredStatus[i] = true;
            }
            else
            {
                triggeredStatus[i] = false;
            }
        }
    }

    void CheckAllTriggered()
    {
        allTriggered = true;
        foreach (var triggered in triggeredStatus)
        {
            if (!triggered)
            {
                allTriggered = false;
                break;
            }
        }
        bool isSwitchedOn = buttonVR.SwitchedOn();

        if (allTriggered && isSwitchedOn)
        {
            messageText.enabled = true; // Show text if all trigger points are triggered
            displayNumber.enabled = true;
            displayNumber2.enabled = true;
            Debug.Log("All trigger points are triggered!");
        }
        else
        {
            messageText.enabled = false; // Hide text if any trigger point is not triggered
            displayNumber.enabled = false;
            displayNumber2.enabled = false;
        }
    }
    public bool Triggered()
    {
        return allTriggered;
    }
 // Starting trigger stage

}