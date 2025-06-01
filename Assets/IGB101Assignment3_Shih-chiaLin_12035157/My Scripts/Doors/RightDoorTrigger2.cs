using UnityEngine;

public class RightDoorTrigger2 : MonoBehaviour
{
    public RightDoor2 door_controller;

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
