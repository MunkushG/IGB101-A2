using UnityEngine;

public class Bullet_Shooter : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform CannonBarrel;
    public Transform BulletSpawnPoint;
    public float shootPower = 700f;
    public float offsetDistance = 0.5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float angleZ = Random.Range(70f, 85f);
            float angleY = Random.Range(-20f, 20f);
            Quaternion newRotation = Quaternion.Euler(0f, angleY, angleZ);
            CannonBarrel.localRotation = newRotation;
            Vector3 shootDirection = -BulletSpawnPoint.right;
            Vector3 spawnPosition = BulletSpawnPoint.position + shootDirection * offsetDistance;
            GameObject newBullet = Instantiate(BulletPrefab, spawnPosition, BulletSpawnPoint.rotation);
            Rigidbody bulletRigidbody = newBullet.GetComponent<Rigidbody>();
            bulletRigidbody.AddForce(shootDirection * shootPower);

        }
    }
}
