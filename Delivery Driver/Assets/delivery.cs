using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyPackage;

    [SerializeField] Color32 carColor = new Color32(1,1,1,1); 
    [SerializeField] Color32 noCarColor = new Color32(1,1,1,1);

    SpriteRenderer spriteRenderer;
     void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("�arpma ger�ekle�ti ");
      
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package" && hasPackage == false)
        {
            hasPackage = true;
            Debug.Log("Paket al�nd�");
            spriteRenderer.color = carColor; 
            Destroy(collision.gameObject, destroyPackage);

        }
        if (collision.tag == "Customer" && hasPackage == true )
        {
            Debug.Log("Paket m��teriye teslim edildi");
             hasPackage = false;
            spriteRenderer.color = noCarColor;
        }

    }
}
