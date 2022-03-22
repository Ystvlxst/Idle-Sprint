using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiSpeedBooster : MonoBehaviour
{
    [SerializeField] PlayerMover _playerMover;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _playerMover.BoostSpeed(2f);
        }
    }
}
