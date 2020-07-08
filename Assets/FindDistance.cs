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
           
            if (dist <= minimumdistance)
            {
                rectTransform.localScale = new Vector3(1, 1, 1);     
            }
            else
            {
                rectTransform.localScale = new Vector3(3f, 3f, 3f);
               
            }
        }
    } 
}
