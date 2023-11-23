using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetDoors : MonoBehaviour, IInteractable
{
    [SerializeField] bool leftCabinetdoor;
    [SerializeField] bool rightCabinetDoor;

    Cabinet cabinet;
    public void Interact()
    {
        if (leftCabinetdoor) { cabinet.CabinetDoorLeftInteraction(); }
        if (rightCabinetDoor) { cabinet.CabinetDoorRightInteraction(); }

    }

    void Start()
    {
        cabinet = FindAnyObjectByType<Cabinet>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
