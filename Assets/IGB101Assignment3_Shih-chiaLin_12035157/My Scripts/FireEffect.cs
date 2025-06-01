using UnityEngine;

public class FireEffect : MonoBehaviour
{
    public ParticleSystem[] FireParticles;
    void OnMouseDown()
    {
        int i = 0;
        while (i < FireParticles.Length)
        {
            if (FireParticles[i] != null)
            {
                FireParticles[i].Play();
            }
            i = i + 1;
        }
    }
}