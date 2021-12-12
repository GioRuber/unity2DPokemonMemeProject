using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{

    private VideoPlayer videoPlayer;

    void Awake()
    {
        // Getting VideoPlayer component created on unity editor
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Update()
    {
        if (videoPlayer.time <= 23 && Input.anyKeyDown)
        {
            videoPlayer.time = 23;
        }

        if (videoPlayer.time > 27 && videoPlayer.time <= 69 && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneName: "SampleScene");
        }
    }
}
