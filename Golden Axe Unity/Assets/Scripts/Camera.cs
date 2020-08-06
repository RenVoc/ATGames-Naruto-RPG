using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    int distrance = -10;
    float lift = 1.5f;

    void Update() {
        transform.position = new Vector3(0, lift, distrance) + target.position;
        transform.LookAt(target);
    }
}
