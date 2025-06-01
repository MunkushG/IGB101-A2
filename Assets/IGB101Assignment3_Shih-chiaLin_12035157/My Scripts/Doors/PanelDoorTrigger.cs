using UnityEngine;

public class PanelDoorTrigger : MonoBehaviour
{
    public PanelDoorControl door_controller;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door_controller.OpenDoor(other.transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door_controller.StartCloseTimer();
        }
    }
}
