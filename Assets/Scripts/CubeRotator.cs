using DG.Tweening;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    private const int LoopsCount = -1;

    private readonly Ease _rotationEase = Ease.Linear;
    private readonly float _rotationDuration = 2f;
    private Vector3 _rotationAngles = new(0f,360f,0f);

    private Tween _rotationTween;

    private void Start()
    {
        StartRotation();
    }

    private void StartRotation()
    {
        _rotationTween?.Kill();

        _rotationTween = transform.DORotate(_rotationAngles, _rotationDuration).SetRelative().SetEase(_rotationEase).SetLoops(LoopsCount, LoopType.Restart).SetLink(gameObject);
    }

}
