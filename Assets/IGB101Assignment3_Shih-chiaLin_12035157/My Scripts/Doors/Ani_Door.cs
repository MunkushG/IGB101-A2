using UnityEngine;

public class Ani_Door : MonoBehaviour
{
    private Animation door_anim;

    void Start()
    {
        door_anim = GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            door_anim.Play();
        }
    }
}
