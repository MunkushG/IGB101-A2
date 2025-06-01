using UnityEngine;

public class DungeonDoorTrigger : MonoBehaviour
{
    public DungeonDoor door_controller;

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
