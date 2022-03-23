using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private CameraMover _cameraMover;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _playerMover.BoostSpeed(-2);
            _cameraMover.ReactBoost(1);
        }
    }
}
