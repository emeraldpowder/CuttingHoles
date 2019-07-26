using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.layer = 9;
        Debug.Log("Enter");
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.layer = 0;
        Debug.Log("Exit");
    }
}
