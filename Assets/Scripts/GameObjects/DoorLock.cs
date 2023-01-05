using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    [SerializeField] string combination;
    [SerializeField] DoorWheel wheel1;
    [SerializeField] DoorWheel wheel2;
    [SerializeField] DoorWheel wheel3;
    [SerializeField] DoorWheel wheel4;
    EnterGarden enterGarden;
    [SerializeField] GameObject moveTo;

    private void Awake()
    {
        enterGarden = FindObjectOfType<EnterGarden>();
    }

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
        enterGarden.CanEnter();
        moveTo.SetActive(false);
    }
}
