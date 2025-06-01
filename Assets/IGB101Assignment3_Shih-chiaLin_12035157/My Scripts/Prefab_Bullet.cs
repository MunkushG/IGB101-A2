using UnityEngine;

public class Prefab_Bullet : MonoBehaviour
{
    public GameObject explosion_effect_prefab;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bullet hit: " + collision.gameObject.name);
        if (explosion_effect_prefab != null)
        {
            Vector3 hit_point = collision.contacts[0].point;
            GameObject explosion = Instantiate(explosion_effect_prefab, hit_point, Quaternion.identity);
            Destroy(explosion, 2f);
        }
        if (collision.gameObject.tag == "BulletTarget")
        {
            Renderer rend = collision.gameObject.GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material.color = Color.black;
                Debug.Log("BulletTarget has been hit! Color changed to black.");
            }
        }
        Destroy(gameObject);
    }
}
