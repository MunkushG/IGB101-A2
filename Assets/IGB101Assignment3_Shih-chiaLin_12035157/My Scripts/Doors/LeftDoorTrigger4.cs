using UnityEngine;

public class LeftDoorTrigger4 : MonoBehaviour
{
    public LeftDoor4 door_controller;

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
