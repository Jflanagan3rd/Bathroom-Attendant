using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColognePickUp : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject cologneBottleTable;
    bool colognePickedUp;

    CologneSystem cologneSystem;
    void Start()
    {
        cologneSystem = FindObjectOfType<CologneSystem>();
    }
    public void Interact()
    {
        if (!colognePickedUp)
        {
            cologneBottleTable.SetActive(false);
            cologneSystem.blueCologneOn = true;
            StartCoroutine("TrueBoolDelay");
        }
        if (colognePickedUp)
        {
            cologneBottleTable.SetActive(true);
            cologneSystem.blueCologneOn = false;
            StartCoroutine("FalseBoolDelay");
        }
    }


    void Update()
    {
        
    }
    IEnumerator TrueBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        colognePickedUp = true;
    }
    IEnumerator FalseBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        colognePickedUp = false;
    }
}
