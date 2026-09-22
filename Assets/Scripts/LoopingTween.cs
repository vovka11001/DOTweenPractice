using DG.Tweening;
using UnityEngine;

public abstract class LoopingTween : MonoBehaviour
{
    private const int LoopCount = -1;

    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private float _duration = 1.5f;

    private Ease _ease = Ease.Linear;
    private Tween _tween;

    private void Start()
    {
        StartTween();
    }

    private void StartTween()
    {
        _tween?.Kill();

        _tween = CreateTween(_duration).SetEase(_ease).SetLoops(LoopCount,_loopType).SetLink(gameObject);
    }

    protected abstract Tween CreateTween(float duration);
}