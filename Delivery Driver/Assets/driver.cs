using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.2f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float speedCar = 20f;
    [SerializeField] float slowerCar = 10f;
   

    void Update()
    {
        // bu deðerler objenin sag-sol ya da yukarý-aþaðý inmesini saðlar 
        //Baþýnda olan - iþareti normalde tersi çalýþanýdüze döndürür 
        float streetAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        
        // obje z ekseninde 0.2 derece dönme yapar
        transform.Rotate(0, 0, -streetAmount);

       // obje y ekseninde 0.01 derece hareket eder
        transform.Translate(0,moveAmount,0);
       

    }
     void OnCollisionEnter2D(Collision2D collision)
     {
           moveSpeed = slowerCar;
     }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Speed")
        {
            moveSpeed = speedCar;
        }
        

    }
}
