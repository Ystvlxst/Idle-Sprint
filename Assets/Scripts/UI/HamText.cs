using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class HamText : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Transform _canvas;

    public void GetHam()
    {
        Instantiate(_text, _canvas);
        _text.gameObject.SetActive(true);
    }
}
