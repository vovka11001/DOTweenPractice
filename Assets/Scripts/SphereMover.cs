using DG.Tweening;
using UnityEngine;

public class SphereMover : LoopingTween
{
    [SerializeField] private Transform _target;

    protected override Tween CreateTween(float duration)
    {
        return transform.DOMove(_target.position, duration);
    }
}