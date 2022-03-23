using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Player _target;
    [SerializeField] private Vector3 _position;

    private float _cameraPositionZ = 7;
    private float _targetCameraPositionZ;

    private void LateUpdate()
    {
        transform.position = new Vector3(_position.x, _position.y, _target.transform.position.z - _cameraPositionZ);
    }

    private IEnumerator ReactionBoost()
    {
        var waitForSeconds = new WaitForSeconds(1);
        int timescaleFactor = 2;

        while (_cameraPositionZ != _targetCameraPositionZ)
        {
            _cameraPositionZ = Mathf.MoveTowards(_cameraPositionZ, _cameraPositionZ += _targetCameraPositionZ, timescaleFactor * Time.deltaTime);
            yield return waitForSeconds;
        }
    }

    public void ReactBoost(float reactForce)
    {
        _targetCameraPositionZ = reactForce;
        StartCoroutine(ReactionBoost());
    }
}
