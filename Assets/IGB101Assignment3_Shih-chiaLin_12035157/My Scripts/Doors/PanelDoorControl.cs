using UnityEngine;

public class PanelDoorControl : MonoBehaviour
{
    public Transform door_panel;
    public float open_speed = 100f;
    public float delay_before_close = 10f;
    public float open_angle = 90f;

    private Quaternion closed_rotation;
    private Quaternion target_rotation;
    private bool is_moving = false;
    private bool is_open = false;
    private float close_timer = 0f;

    void Start()
    {
        if (door_panel == null)
        {
            Debug.Log("Please assign the door panel.");
            enabled = false;
            return;
        }

        closed_rotation = door_panel.rotation;
    }

    void Update()
    {
        if (is_moving)
        {
            door_panel.rotation = Quaternion.RotateTowards
                (door_panel.rotation, target_rotation, open_speed * Time.deltaTime);

            if (Quaternion.Angle(door_panel.rotation, target_rotation) < 0.5f)
            {
                door_panel.rotation = target_rotation;
                is_moving = false;
            }
        }

        if (is_open && !is_moving)
        {
            if (close_timer > 0f)
            {
                close_timer -= Time.deltaTime;
                if (close_timer <= 0f)
                {
                    target_rotation = closed_rotation;
                    is_moving = true;
                    is_open = false;
                }
            }
        }
    }

    public void OpenDoor(Transform player)
    {
        if (is_open || is_moving)
            return;
        Vector3 to_player = door_panel.position - player.position;
        float angle = Vector3.SignedAngle(player.forward, to_player, Vector3.up);
        if (angle >= 0)
        {
            target_rotation = closed_rotation * Quaternion.Euler(0, open_angle, 0);
        }
        else
        {
            target_rotation = closed_rotation * Quaternion.Euler(0, -open_angle, 0);
        }
        is_moving = true;
        is_open = true;
    }

    public void StartCloseTimer()
    {
        if (is_open && !is_moving && close_timer <= 0f)
        {
            close_timer = delay_before_close;
        }
    }
}
