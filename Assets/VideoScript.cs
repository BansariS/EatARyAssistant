using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
     Invoke("playVideo", 3.0f);
    }
    
    void playVideo()
    {
        videoPlayer.Play();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
