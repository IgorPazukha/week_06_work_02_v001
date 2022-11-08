using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _health = 100f;
    private float _minHealht = 0f;
    private float _maxHealth = 100f;
    private float _valueHealth = 10f;
    [SerializeField] private HealthBar _healthBar;

    public float Health => _health;
    public float MinHealth => _minHealht;
    public float MaxHealth => _maxHealth;

    public void IncreaseHealth()
    {
        if (_health < _maxHealth && _health > _minHealht - 1)
        {
            _health += _valueHealth;
            _healthBar.ChangeSlider();
        }
    }
    public void TakeDamage()
    {
        if (_health > _minHealht && _health < _maxHealth + 1)
        {
            _health -= _valueHealth;
            _healthBar.ChangeSlider();
        }
    }
}
