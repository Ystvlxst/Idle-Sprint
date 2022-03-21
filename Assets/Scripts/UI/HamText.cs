using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HamText : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void Start()
    {
        _text.gameObject.SetActive(false);
    }

    private IEnumerator TextAlphaControl()
    {
        _text.CrossFadeAlpha(1, 0.5f, false);
        yield return new WaitForSeconds(0.5f);
        _text.CrossFadeAlpha(0, 0.5f, false);
    }

    public void GetHam()
    {
        _text.gameObject.SetActive(true);
        StartCoroutine(TextAlphaControl());
    }
}
