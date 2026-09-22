using DG.Tweening;
using UnityEngine;

public class CubeRotator : LoopingTween
{
    private Vector3 _rotationAngles = new(0f,360f,0f);

    protected override Tween CreateTween(float duration)
    {
        return transform.DORotate(_rotationAngles, duration,RotateMode.FastBeyond360).SetRelative();
    }
}