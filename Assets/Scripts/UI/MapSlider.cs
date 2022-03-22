using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MapSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _target;
    [SerializeField] private TMP_Text _milesText;
    [SerializeField] private SpeedText _speedText;

    private float _valueFactor = 0.45f;
    
    private void Update()
    {
        CheckPlayerPosition();
    }

    private void CheckPlayerPosition()
    {
        _slider.value -= _speedText.Speed * _valueFactor * Time.deltaTime;
        _milesText.text = ((int)_slider.value).ToString() + " / 600 Miles";
    }
}
