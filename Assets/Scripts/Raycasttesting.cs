
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Raycasttesting : MonoBehaviour
{

    public GameObject videoGameObject;
    public GameObject rawImageGameObject;
    private VideoPlayer vPlayer;
    private Image rawImage;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rawImage = rawImageGameObject.GetComponent<Image>();
        vPlayer = videoGameObject.GetComponent<VideoPlayer>();
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawLine(transform.position, transform.position + transform.forward * 25, Color.red);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "foodmap")
            {
                Debug.DrawLine(hit.point, hit.point + transform.up * 5, Color.green);
                rawImageGameObject.SetActive(true);
                videoGameObject.SetActive(true);
                vPlayer.Play();
            }
        }
        else
        {
            rawImageGameObject.SetActive(false);
        }
    }
}
