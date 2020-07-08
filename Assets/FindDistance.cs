using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindDistance : MonoBehaviour
{
    public Transform other;
    public RectTransform rectTransform;

    private float minimumdistance = 358.8824F;
    

    
    void FixedUpdate()
    {
        if (other)
        {
            float dist = Vector3.Distance(other.position, transform.position);
            Debug.Log("other.position is " + other.position);
            Debug.Log("transform.position is " + transform.position);
            Debug.Log("Distance to other:"+ dist);
            if (dist <= minimumdistance)
            {
                rectTransform.localScale = new Vector3(1, 1, 1);
                Debug.Log("scale is not increased");
            }
            else
            {
                rectTransform.localScale = new Vector3(3f, 3f, 3f);
                Debug.Log("scale is increased");
            }
        }
    } 
}
