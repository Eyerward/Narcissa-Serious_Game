using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock2 : MonoBehaviour
{
    [SerializeField] string combination;
    [SerializeField] DoorWheel2 wheel1;
    [SerializeField] DoorWheel2 wheel2;
    [SerializeField] DoorWheel2 wheel3;
    [SerializeField] DoorWheel2 wheel4;
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
        FindObjectOfType<PlayerController>().ObsPos();
        FindObjectOfType<LeavesOut>().Revealing();
        moveTo.SetActive(false);
    }
}
