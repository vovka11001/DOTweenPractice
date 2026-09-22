using DG.Tweening;
using UnityEngine;

public class CubeMotion : MonoBehaviour
{
    private const int LoopCount = -1;

    [SerializeField] private Transform _targetPosition;

    private float _targetScale = 1.5f;
    private float _motionDuration = 2f;

    private Ease _motionEase = Ease.InOutSine;
    private Ease _rotationEase = Ease.Linear;

    private Vector3 _rotationAngles = new(0f, 360f, 0f);
    private Vector3 _startPosition;
    private Vector3 _startScale;

    private Sequence _motionSequence;

    private void Start()
    {
        _startPosition = transform.position;
        _startScale = transform.localScale;

        StartMotion();
    }

    private void StartMotion()
    {
        _motionSequence?.Kill();

        _motionSequence = DOTween.Sequence();

        _motionSequence.Append(transform.DOMove(_targetPosition.position, _motionDuration).SetEase(_motionEase));
        _motionSequence.Join(transform.DORotate(_rotationAngles,_motionDuration).SetRelative().SetEase(_rotationEase));
        _motionSequence.Join(transform.DOScale(_targetScale,_motionDuration).SetEase(_rotationEase));

        _motionSequence.SetLoops(LoopCount, LoopType.Restart).OnStepComplete(ResetToStart).SetLink(gameObject);
    }

    private void ResetToStart()
    {
        transform.position = _startPosition;
        transform.localScale = _startScale;
    }
}