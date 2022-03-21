using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _speedFactor = 0.1f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 position = transform.position;
        _speed += Time.deltaTime * _speedFactor;
        position.z += _speed * Time.deltaTime;
        transform.position = position;
    }
}
