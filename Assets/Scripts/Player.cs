using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System.Collections;

public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private ParticleSystem _groundParts;

    private int _hamCount;

    public UnityEvent HamEated;
    public int HamCount => _hamCount;

    private void Start()
    {
        _hamCount = 0;
        PartcleControl();
    }

    private void Update()
    {
        _scoreText.text = _hamCount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ham ham))
        {
            HamEated?.Invoke();
            _hamCount++;
            ham.gameObject.SetActive(false);
        }
    }

    private IEnumerator OnOffParticle()
    {
        while (_groundParts != null)
        {
            _groundParts.Play();
            yield return new WaitForSeconds(2f);
            _groundParts.Stop();
            yield return new WaitForSeconds(2f);
        }
    }

    private void PartcleControl()
    {
        StartCoroutine(OnOffParticle());
    }

    public void BuyBooster(int price)
    {
        _hamCount -= price;
    }
}
