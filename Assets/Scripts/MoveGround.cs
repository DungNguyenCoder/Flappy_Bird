using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    [SerializeField] float _speed = 0.75f;

    void Update()
    {
        if (!GameManager.instance.hasStarted) return;
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
