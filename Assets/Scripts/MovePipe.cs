using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        if (!GameManager.instance.hasStarted) return;
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
