using UnityEngine;
using UnityEngine.Video;

public class TriggerVideoFromOtherObject : MonoBehaviour
{
    public GameObject targetObject;     
    public GameObject videoObject;      
    public float triggerDistance = 8f;  

    private Transform cameraTransform;
    private VideoPlayer videoPlayer;

    void Start()
    {
        if (Camera.main != null)
        {
            cameraTransform = Camera.main.transform;
        }

        if (videoObject != null)
        {
            videoPlayer = videoObject.GetComponent<VideoPlayer>();
            if (videoPlayer != null)
            {
                videoPlayer.playOnAwake = false;
                videoPlayer.Pause();
            }
        }
    }

    void Update()
    {
        if (targetObject == null || videoPlayer == null || cameraTransform == null)
            return;

        float distance = Vector3.Distance(targetObject.transform.position, cameraTransform.position);

        if (distance <= triggerDistance)
        {
            if (!videoPlayer.isPlaying)
            {
                videoPlayer.Play();
            }
        }
        else
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
        }
    }
}
