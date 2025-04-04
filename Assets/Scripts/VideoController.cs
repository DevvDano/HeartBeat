using UnityEngine;
using UnityEngine.Video;
using System.Collections; // Include this namespace for IEnumerator

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.Prepare();
        StartCoroutine(PlayAfterPreparation());
    }

    private IEnumerator PlayAfterPreparation()
    {
        while (!videoPlayer.isPrepared)
        {
            yield return null; // Wait until the video is fully prepared
        }
        videoPlayer.Play();
    }
}
