using DG.Tweening;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    private const int LoopsCount = -1;

    [SerializeField] private Transform _targetPosition;

    private readonly Ease _moveEase = Ease.Linear;
    private readonly float _moveDuration = 2f;

    private Tween _moveTween;

    private void Start()
    {
        StartMove();
    }

    private void StartMove()
    {
        _moveTween?.Kill();

        _moveTween = transform.DOMove(_targetPosition.position, _moveDuration).SetEase(_moveEase).SetLoops(LoopsCount, LoopType.Yoyo).SetLink(gameObject);
    }
}