using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColognePickUp : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject cologneBottleTable;
    bool colognePickedUp;

    CologneSystem cologneSystem;

    [SerializeField] bool orangeBottle;
    [SerializeField] bool blueBottle;
    [SerializeField] bool pinkBottle;
    [SerializeField] bool yellowBottle;

    Interactor interactor;
    void Start()
    {
        cologneSystem = FindObjectOfType<CologneSystem>();
        interactor = FindAnyObjectByType<Interactor>();
    }
    public void Interact()
    {
        if (!colognePickedUp && !interactor.interactorBUSY)
        {
            
            cologneBottleTable.SetActive(false);
            if (blueBottle) {cologneSystem.blueCologneOn = true; }
            if (orangeBottle) { cologneSystem.orangeCologneOn = true; }
            if (pinkBottle) { cologneSystem.pinkCologneOn = true; }
            if (yellowBottle) { cologneSystem.yellowCologneOn = true; }


            StartCoroutine("TrueBoolDelay");
        }
        if (colognePickedUp)
        {
            cologneBottleTable.SetActive(true);
            if(blueBottle)  {cologneSystem.blueCologneOn = false;}
            if (orangeBottle) {cologneSystem.orangeCologneOn = false; }
            if (pinkBottle) {cologneSystem.pinkCologneOn = false; }
            if (yellowBottle) { cologneSystem.yellowCologneOn = false; }

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
        interactor.interactorBUSY = true;
    }
    IEnumerator FalseBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        colognePickedUp = false;
        interactor.interactorBUSY = false;
    }
}
