using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    private float _health = 100f;
    private float _minHealht = 0f;
    private float _maxHealth = 100f;
    private float _valueHealth = 10f;

    public float Health => _health;
    public float MinHealth => _minHealht;
    public float MaxHealth => _maxHealth;

    public void OnButtonClickHealth()
    {
        if (_health < _maxHealth)
        {
            _health += _valueHealth;
        }
    }
    public void OnButtonClickDamage()
    {
        if (_health > _minHealht)
        {
            _health -= _valueHealth;
        }
    }
}
