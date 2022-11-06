using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBarSet : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Image _healthBar;
    [SerializeField] private Color _maxHealthColor;
    [SerializeField] private PlayerState _player;

    private float _timeTransation = 20f;
    private float _timeDuration;
    private Color _minHealthColor = Color.red;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        ChangeValue();
    }

    private void ChangeValue()
    {
        float colorChange = _player.Health / _player.MaxHealth;

        _timeDuration = _timeTransation * Time.deltaTime;
        _slider.value = Mathf.MoveTowards(_slider.value, _player.Health, _timeDuration);
        _healthBar.color = Color.Lerp(_minHealthColor, _maxHealthColor, colorChange);
        Debug.Log(_player.Health);
    }
}
