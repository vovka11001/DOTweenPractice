using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class CylinderColorChanger : LoopingTween
{
    private Color _targetColor = Color.red;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    protected override Tween CreateTween(float duration)
    {
        return _renderer.material.DOColor(_targetColor, duration);
    }
}