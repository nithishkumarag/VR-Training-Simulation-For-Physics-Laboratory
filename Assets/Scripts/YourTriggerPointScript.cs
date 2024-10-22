using UnityEngine;

public class YourTriggerPointScript : MonoBehaviour
{
    //public int triggerIndex;
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("YourTriggerTag"))
        {
            Debug.Log("Enter");
            triggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("YourTriggerTag"))
        {
            Debug.Log("Exit");
            triggered = false;
        }
    }

    public bool IsTriggered()
    {
        return triggered;
    }
    /**public int GetTriggerIndex()
    {
        return triggerIndex;
    }**/
}