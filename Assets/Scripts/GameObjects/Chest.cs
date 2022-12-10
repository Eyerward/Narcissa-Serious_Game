using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;

public class Chest : MonoBehaviour
{
    [SerializeField] GameObject puzzle;
    public void OpenChest()
    {
        transform.DOLocalRotate(new Vector3(-180, 0, 0), 1f, RotateMode.FastBeyond360)
            .SetEase(Ease.OutBounce);
        Invoke("Opened", 1f);
    }

    void Opened()
    {
        DOTween.Kill(gameObject);
        puzzle.SetActive(true);
        FindObjectOfType<PuzzleReveal>().Reveal();
    }
}
