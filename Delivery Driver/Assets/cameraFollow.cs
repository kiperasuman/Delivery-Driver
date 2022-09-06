using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // kamera araba nesnesi ile ayný olmalýdýr 
    [SerializeField] GameObject gameObject;

// her karede güncelleme yapacaðý için update fonksiyonuna koyarýz
    void LateUpdate()
    {
        
        transform.position = gameObject.transform.position + new Vector3 (0,0,-10);

    }
}
