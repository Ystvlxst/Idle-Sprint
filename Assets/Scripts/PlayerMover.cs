using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMover : MonoBehaviour, IDragHandler
{
    [SerializeField] private GameObject _ground;
    [SerializeField] private Player _player;
    [SerializeField] private float _speed;

    private float _speedFactor = 0.1f;

    public float Speed => _speed;

    private void Update()
    {
        MoveForvard();
    }

    private void MoveForvard()
    {
        Vector3 position = _ground.transform.position;
        _speed -= Time.deltaTime * _speedFactor;
        position.z += _speed * Time.deltaTime;
        _ground.transform.position = position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        float positionXfactor = 0.002f;
        Vector2 delta = eventData.delta;

        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        {
            Vector3 position = _player.transform.position;
            position.x += delta.x * positionXfactor;
            _player.transform.position = position;
        }
    }

    public void BoostSpeed(float speed)
    {
        _speed += speed;
    }
}
