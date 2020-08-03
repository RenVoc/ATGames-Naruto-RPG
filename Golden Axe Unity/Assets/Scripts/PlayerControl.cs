using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalSpeed;
    float speedX;
    public float verticalImpulse;
    Rigidbody2D rb;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /*Функция описывающая нажатие кнопок.*/
    void FixedUpdate()
    {
        /*кнопка влево*/
        if (Input.GetKey(KeyCode.A))
        {
            speedX = -horizontalSpeed;
        }
        /*кнопка вправо*/
        else if (Input.GetKey(KeyCode.D)){
            speedX = horizontalSpeed;
        }
        /*прыжок, с условием что персонаж на земле*/
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded){
            rb.AddForce(new Vector2(0, verticalImpulse), ForceMode2D.Impulse);    
        }
        transform.Translate(speedX, 0, 0);
        speedX = 0; 
    }


    //Функция проверки на земле ли объект
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
