using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float rotationSpeed;
    
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime, Space.World);
    }
}
