using UnityEngine;

public class RightDoorTrigger3 : MonoBehaviour
{
    public RightDoor3 door_controller;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (door_controller != null)
            {
                door_controller.StartMoving();
            }
        }
    }
}
