using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Interactable : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Destroy(gameObject);
       
    }

   
}
