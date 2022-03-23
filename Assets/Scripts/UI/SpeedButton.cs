using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SpeedButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Text _levelText;
    [SerializeField] private Text _pricelText;
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private CameraMover _cameraMover;
    [SerializeField] private Player _player;
    [SerializeField] private ParticleSystem _clickButtonEffect;

    private int _level = 1;
    private int _boost = 1;
    private int _price = 5;
    private int _priceIncrease = 10;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnSpeedButtonClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnSpeedButtonClick);
    }

    private void OnSpeedButtonClick()
    {
        if (_player.HamCount >= _price)
        {
            _clickButtonEffect.Play();
            _price += _priceIncrease;
            _player.BuyBooster(_price);
            _playerMover.BoostSpeed(-_boost);
            _cameraMover.ReactBoost(1);
            _level++;
            _levelText.text = "Level " + _level;
            _pricelText.text = _price.ToString();
        }
    }
}
