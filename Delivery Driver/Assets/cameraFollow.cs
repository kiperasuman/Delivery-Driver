using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // kamera araba nesnesi ile ayn� olmal�d�r 
    [SerializeField] GameObject gameObject;

// her karede g�ncelleme yapaca�� i�in update fonksiyonuna koyar�z
    void LateUpdate()
    {
        
        transform.position = gameObject.transform.position + new Vector3 (0,0,-10);

    }
}
