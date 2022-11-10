using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityEvent OnHealthChange;

    private float _health = 100f;
    private float _minHealht = 0f;
    private float _maxHealth = 100f;
    private float _valueHealth = 10f;

    public float Health => _health;
    public float MinHealth => _minHealht;
    public float MaxHealth => _maxHealth;

    public void IncreaseHealth()
    {
        _health = Mathf.Clamp(_health += _valueHealth, _minHealht, _maxHealth);
        OnHealthChange.Invoke();
    }
    public void TakeDamage()
    {
        _health = Mathf.Clamp(_health -= _valueHealth, _minHealht, _maxHealth);
        OnHealthChange.Invoke();
    }
}
