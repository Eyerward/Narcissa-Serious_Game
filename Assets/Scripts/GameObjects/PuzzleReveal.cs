using DG.Tweening;
using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleReveal : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject hud;
    void EndAnim()
    {
        DOTween.Kill(gameObject);
    }
    void Final()
    {
        FindObjectOfType<PlayerController>().MovableCamera();
        DOTween.Kill(gameObject);
        gameObject.SetActive(false);
    }
    public void Reveal()
    {
        Invoke("EndAnim", 1f);
        transform.DOMoveX(player.transform.position.x, 1f)
            .SetEase(Ease.InOutQuad);
        transform.DOMoveY(player.transform.position.y, 1f)
            .SetEase(Ease.OutBack);
        transform.DOMoveZ(player.transform.position.z + 2, 1f)
            .SetEase(Ease.InOutQuad);
        transform.DOScale(new Vector3(4f, 4f, 4f), 1f)
            .SetEase(Ease.InOutQuad);

    }
    private void OnMouseUpAsButton()
    {
        transform.DOMoveY(-7, 1f).SetEase(Ease.InBack);
        transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 1f).SetEase(Ease.InQuad);
        Invoke("Final", 1f);
        hud.SetActive(true);
    }
}
