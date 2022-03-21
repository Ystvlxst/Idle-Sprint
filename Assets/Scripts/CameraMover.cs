using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Player _target;
    [SerializeField] private Vector3 _position;

    private int _cameraPositionZ = 7;
    private void LateUpdate()
    {
        transform.position = new Vector3(_position.x, _position.y, _target.transform.position.z - _cameraPositionZ);
    }
}
