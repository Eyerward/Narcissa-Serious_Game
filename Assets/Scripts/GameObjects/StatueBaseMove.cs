using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;

public class StatueBaseMove : MonoBehaviour
{
    [SerializeField] GameObject puzzle;
    
    public void OpenBase()
    {
        DOTween.Kill(gameObject);
        Quaternion quat = Quaternion.Euler(0, 0, 0);
        transform.DOLocalRotateQuaternion(quat, 2f).SetEase(Ease.OutElastic);
        transform.DOMoveX(5, 2f).SetEase(Ease.InExpo).OnComplete(Opened);
    }

    void Opened()
    {
        DOTween.Kill(gameObject);
        puzzle.SetActive(true);
        FindObjectOfType<PuzzleReveal>().Reveal();
    }
}
