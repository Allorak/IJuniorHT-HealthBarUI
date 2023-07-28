using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Player _target;
    [SerializeField] private float _damageAmount;

    public void DamagePlayer()
    {
        _target.ApplyDamage(_damageAmount);
    }
}
