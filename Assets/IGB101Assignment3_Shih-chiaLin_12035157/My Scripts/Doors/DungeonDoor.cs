using UnityEngine;

public class DungeonDoor : MonoBehaviour
{
    public Transform door_panel;
    public Transform door_trigger;
    public float open_height = 5f;
    public float open_speed = 2f;
    private Vector3 closed_position;
    private Vector3 open_position;
    private bool is_moving = false;
    private bool is_opened = false;
    private Collider door_panel_collider;
    void Start()
    {
        if (door_panel == null || door_trigger == null)
        {
            Debug.LogError("door_panel or door_trigger is not assigned!");
            this.enabled = false;
            return;
        }
        closed_position = door_panel.position;
        open_position = new Vector3(closed_position.x, closed_position.y + open_height, closed_position.z);
        door_panel_collider = door_panel.GetComponent<Collider>();
    }

    void Update()
    {
        if (is_moving && !is_opened)
        {
            door_panel.position = Vector3.MoveTowards(door_panel.position, open_position, open_speed * Time.deltaTime);
            if (Vector3.Distance(door_panel.position, open_position) < 0.01f)
            {
                is_moving = false;
                is_opened = true;
                if (door_panel_collider != null)
                {
                    door_panel_collider.enabled = false;
                }
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
