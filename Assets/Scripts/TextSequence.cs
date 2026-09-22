using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextSequence : MonoBehaviour
{
    private const string InitialText = "Начало";
    private const string AppendedText = "Середина";
    private const string ScrambledText = "Конец";

    [SerializeField] private Text _targetText;

    private readonly float _typeDuration = 1f;
    private readonly float _appendDuration = 1f;
    private readonly float _scrambledDuration = 1f;
    private readonly float _pauseBetweenSteps = 0.5f;

    private Sequence _textSequence;

    private void Start()
    {
        StartTextSequence();
    }

    private void StartTextSequence()
    {
        _textSequence?.Kill();
        _targetText.text = string.Empty;

        _textSequence = DOTween.Sequence();

        _textSequence.Append(_targetText.DOText(InitialText, _typeDuration));
        _textSequence.AppendInterval(_pauseBetweenSteps);
        _textSequence.Append(_targetText.DOText(AppendedText, _appendDuration));
        _textSequence.AppendInterval(_pauseBetweenSteps);
        _textSequence.Append(_targetText.DOText(ScrambledText, _scrambledDuration,false,ScrambleMode.All));
        _textSequence.SetLink(gameObject);
    }
}