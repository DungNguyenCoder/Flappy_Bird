using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBe : MonoBehaviour
{
    [SerializeField] private float _verlocity = 5f;
    [SerializeField] private float _rotationSpeed = 10f;

    private Rigidbody2D _rb;

    AudioManager audioManager;

    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.simulated = false;
    }

    private void Update()
    {
        if (!GameManager.instance.hasStarted) return;
        _rb.simulated = true;
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            audioManager.PlaySFX(audioManager.wing);
            _rb.velocity = Vector2.up * _verlocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioManager.PlaySFX(audioManager.hit);
        GameManager.instance.GameOver();
    }
}
