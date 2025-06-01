using UnityEngine;

public class RightDoor1 : MonoBehaviour
{
    public Transform door_panel;
    public Transform door_trigger;
    public float open_speed = 2f;

    private Vector3 closed_pos;
    private Vector3 open_pos = new Vector3(-62.66f, 1.98f, 166f);
    private bool is_moving = false;
    private bool is_opened = false;
    private Collider door_panel_collider;

    void Start()
    {
        if (door_panel == null || door_trigger == null)
        {
            Debug.LogError("door_panel or door_trigger is not assigned!");
            enabled = false;
            return;
        }

        closed_pos = door_panel.position;
        door_panel_collider = door_panel.GetComponent<Collider>();
    }

    void Update()
    {
        if (is_moving && !is_opened)
        {
            door_panel.position = Vector3.MoveTowards(
                door_panel.position, 
                open_pos, 
                open_speed * Time.deltaTime);

            if (Vector3.Distance(door_panel.position, open_pos) < 0.01f)
            {
                is_moving = false;
                is_opened = true;

                if (door_panel_collider != null)
                    door_panel_collider.enabled = false;

                door_trigger.gameObject.SetActive(false);
            }
        }
    }

    public void StartMoving()
    {
        if (!is_opened && !is_moving)
        {
            is_moving = true;
        }
    }
}
