using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SpeedButton : MonoBehaviour
{
    [SerializeField] private Button _speedButton;
    [SerializeField] private Text _levelText;
    [SerializeField] private Text _pricelText;
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private Player _player;
    [SerializeField] private ParticleSystem _clickButton;

    private int _level = 1;
    private int _boost = 1;
    private int _price = 5;
    private int _priceIncrease = 10;

    private void OnEnable()
    {
        _speedButton.onClick.AddListener(OnSpeedButtonClick);
    }

    private void OnDisable()
    {
        _speedButton.onClick.RemoveListener(OnSpeedButtonClick);
    }

    private void OnSpeedButtonClick()
    {
        if (_player.HamCount >= _price)
        {
            _clickButton.Play();
            _price += _priceIncrease;
            _player.BuyBooster(_price);
            _playerMover.BoostSpeed(_boost);
            _level++;
            _levelText.text = "Level " + _level;
            _pricelText.text = _price.ToString();
        }
    }
}
