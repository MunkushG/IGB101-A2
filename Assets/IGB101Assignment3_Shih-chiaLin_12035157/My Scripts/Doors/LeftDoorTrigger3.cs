using UnityEngine;

public class LeftDoorTrigger3 : MonoBehaviour
{
    public LeftDoor3 door_controller;

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
