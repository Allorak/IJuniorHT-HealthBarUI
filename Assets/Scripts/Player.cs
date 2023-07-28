using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private UnityEvent _healthChanged;

    public float Health { get; private set; }
    public float MaxHealth => _maxHealth;

    private float _minHealth = 0;

    private void Start()
    {
        Health = _maxHealth;
    }

    public void ApplyDamage(float damage)
    {
        Health = Math.Max(_minHealth, Health - damage);
        _healthChanged?.Invoke();
    }

    public void ApplyHeal(float heal)
    {
        Health = Math.Min(_maxHealth, Health + heal);
        _healthChanged?.Invoke();
    }
}
