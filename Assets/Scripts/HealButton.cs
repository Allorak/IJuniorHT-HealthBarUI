using UnityEngine;

public class HealButton : MonoBehaviour
{
    [SerializeField] private Player _target;
    [SerializeField] private float _healAmount;

    public void HealPlayer()
    {
        _target.ApplyHeal(_healAmount);
    }
}
