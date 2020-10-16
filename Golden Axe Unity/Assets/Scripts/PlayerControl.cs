using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed; // Переменная скорости.
    public float spawnSpeed = 10.0f; // Ускорение.
    private Rigidbody2D myRigidbody; // Объект для содержимого RigigBody2D.
    private Vector3 change; // Переменная оси z.
    public Vector2 curSavePosition; // Переменная для сохранения позиции.
    void Start() {
        myRigidbody = GetComponent<Rigidbody2D>(); // Записываю то, что находится в Rigidbody2D в переменную.
        speed = spawnSpeed; // Начальные скорость и ускорение равны 0.
    }

    public void Update() {
        change = Vector3.zero; // Обнуление переменной. 
        change.x = Input.GetAxisRaw("Horizontal"); // Запись в переменную изменение значения по оси X.
        change.y = Input.GetAxisRaw("Vertical"); // Запись в переменную изменение значения по оси Y.
        if (change != Vector3.zero) { // Если change не 0 по х или y то выполнить функцию MoveChar.
            MoveChar();
        }
        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
            speed = spawnSpeed; // Если нажат шифт, то скорость = ускорение (во фреймах)
        } else {
            speed = 20.0f; // Иначе стандартная скорость (можно отдельно задать в UI Unity
        }
    }

    private void MoveChar() {
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime); // Перемещение объекта в RigidBody2D делаем сдвигая позицию по координатам по нажатию клавиш налету.
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "SavePoint") {
            curSavePosition = transform.position; // Если дошел до сейф-поинта то прошлый сейфпоинт заменяется текущим.
        }
        if(other.tag == "KillPint") {
            transform.position = curSavePosition; // Если попал в килл-поинт, то текущая позиция переносится к сейф-поинту.
        }
    }
}
