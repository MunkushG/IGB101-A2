using UnityEngine;

public class RightDoorTrigger4 : MonoBehaviour
{
    public RightDoor4 door_controller;

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
