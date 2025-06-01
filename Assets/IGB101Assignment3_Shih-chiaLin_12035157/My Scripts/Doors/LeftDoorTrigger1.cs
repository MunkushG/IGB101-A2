using UnityEngine;

public class LeftDoorTrigger1 : MonoBehaviour
{
    public LeftDoor1 door_controller;

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
