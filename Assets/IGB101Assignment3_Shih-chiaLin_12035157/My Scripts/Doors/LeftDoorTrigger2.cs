using UnityEngine;

public class LeftDoorTrigger2 : MonoBehaviour
{
    public LeftDoor2 door_controller;

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
