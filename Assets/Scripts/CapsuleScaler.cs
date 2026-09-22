using DG.Tweening;

public class CapsuleScaler : LoopingTween
{
    private float _targetScale = 1.5f;

    protected override Tween CreateTween(float duration)
    {
        return transform.DOScale(_targetScale, duration);
    }
}