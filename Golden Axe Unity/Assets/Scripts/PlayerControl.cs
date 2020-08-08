using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    public Vector2 curSavePosition;
    void Start() {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    public void Update() {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (change != Vector3.zero) {
            MoveChar();
        }
    }

    private void MoveChar() {
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "SavePoint") {
            curSavePosition = transform.position;
        }
        if(other.tag == "KillPoint") {
            transform.position = curSavePosition;
        }
    }
}
