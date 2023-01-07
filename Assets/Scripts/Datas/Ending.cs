using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject pos1;
    [SerializeField] GameObject pos2;
    [SerializeField] GameObject pos3;
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    void Start()
    {
        PhaseOne();
    }

    void PhaseOne()
    {
        DOTween.Kill(gameObject);
        pos1.transform.DOScale(new Vector3(2, 2, 1), 4f).SetEase(Ease.OutSine).OnComplete(PhaseTwo);
    }
    void PhaseTwo()
    {
        DOTween.Kill(gameObject);
        player.transform.position = pos2.transform.position;
        pos1.SetActive(false);
        pos2.transform.DOScale(new Vector3(2, 2, 1), 4f).SetEase(Ease.OutSine).OnComplete(PhaseThree);
    }

    void PhaseThree()
    {
        DOTween.Kill(gameObject);
        player.transform.position = pos3.transform.position;
        pos2.SetActive(false);
        text1.transform.DOMoveY(0, 5).SetEase(Ease.OutSine);
        Invoke("PhaseFour", 10);
    }


    void PhaseFour()
    {
        DOTween.Kill(gameObject);
        text2.SetActive(true);
        Invoke("PhaseFive", 15);
    }
    void PhaseFive()
    {
        DOTween.Kill(gameObject);
        SceneManager.LoadScene("MENU");
    }
    
}
