using UnityEngine;

public class RightDoorTrigger1 : MonoBehaviour
{
    public RightDoor1 door_controller;

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
