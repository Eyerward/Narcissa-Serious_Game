using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadLock : MonoBehaviour
{
    [SerializeField] string combination;
    [SerializeField] Wheel wheel1;
    [SerializeField] Wheel wheel2;
    [SerializeField] Wheel wheel3;
    [SerializeField] Wheel wheel4;
    [SerializeField] GameObject winText;

    
    public void TryToUnlock()
    {
        Debug.Log("TRYOUT");

        if (wheel1.numValue.ToString() + wheel2.numValue.ToString() + wheel3.numValue.ToString() + wheel4.numValue.ToString() == combination)
        {
            Unlocked();
        }
    }

    void Unlocked()
    {
        Debug.Log("UNLOCKED");
        winText.SetActive(true);
    }
}
