using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;
using UnityEngine.UIElements;

public class Scratcher : MonoBehaviour
{
    int scratchCount = 0;
    [SerializeField] GameObject activate;

    private void OnMouseDown()
    {
        if (scratchCount >= 4)
        {
            DOTween.Kill(gameObject);
            transform.DOMoveZ(transform.position.z - 1, 0.4f).SetEase(Ease.InBack);
            transform.DOMoveY(-10, 1f).SetEase(Ease.InBack).OnComplete(EndAnim);
            activate.SetActive(true);
            FindObjectOfType<PuzzleReveal>().Reveal();
        }
        else
        {
            scratchCount++;
            transform.eulerAngles = new Vector3(0, 0, scratchCount*8);
            DOTween.Kill(gameObject);
            Quaternion quat = Quaternion.Euler(0, 0, 0);
            transform.DOLocalRotateQuaternion(quat, 0.5f).SetEase(Ease.OutElastic);
        }
    }

    void EndAnim()
    {
        Destroy(gameObject);
    }
}
