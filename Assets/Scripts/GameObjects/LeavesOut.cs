using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;

public class LeavesOut : MonoBehaviour
{
    [SerializeField] GameObject puzzle;

    public void Revealing()
    {
        transform.DOMoveY(-8, 2).SetEase(Ease.InElastic).OnComplete(Opened);
    }

    void Opened()
    {
        DOTween.Kill(gameObject);
        puzzle.SetActive(true);
        FindObjectOfType<PuzzleReveal>().Reveal();
    }
}
