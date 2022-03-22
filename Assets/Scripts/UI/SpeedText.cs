using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedText : MonoBehaviour
{
    [SerializeField] private PlayerMover _target;
    [SerializeField] private TMP_Text _speedLabel;

    private float _speed;
    private float _milesFactor = 3.6f;

    public float Speed => _speed;

    private void Update()
    {
        CheckSpeed();
    }

    private void CheckSpeed()
    {
        _speed = _target.Speed * _milesFactor;
        _speedLabel.text = ((int)-_speed) + " MPH";
    }
}
