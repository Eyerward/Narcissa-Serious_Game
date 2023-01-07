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
    [SerializeField] GameObject moveTo;

    public void TryToUnlock()
    {
        // Debug.Log("TRYOUT");

        if (wheel1.numValue.ToString() + wheel2.numValue.ToString() + wheel3.numValue.ToString() + wheel4.numValue.ToString() == combination)
        {
            Invoke("Unlocked", 1f);
            wheel1.PadUnlocked();
            wheel2.PadUnlocked();
            wheel3.PadUnlocked();
            wheel4.PadUnlocked();
        }
    }

    void Unlocked()
    {
        Debug.Log("UNLOCKED");
        FindObjectOfType<PlayerController>().Revenir();
        FindObjectOfType<Chest>().OpenChest();
        moveTo.SetActive(false);
    }
}
