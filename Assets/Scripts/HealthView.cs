using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _animationDuration;

    public void Render(Player player)
    {
        _slider.DOValue(player.Health / player.MaxHealth, _animationDuration);
    }
}
