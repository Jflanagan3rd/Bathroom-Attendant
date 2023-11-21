using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CologneSystem : MonoBehaviour
{
    [SerializeField] GameObject blueCologne;

    [SerializeField] ParticleSystem blueSpray;
    [SerializeField] AudioSource cologneSpraySFX;

    public bool blueCologneOn;

    Item_Instantiator itemInstantiator;
    void Start()
    {
        itemInstantiator = FindObjectOfType<Item_Instantiator>();
    }

    void Update()
    {
        if (blueCologneOn)
        {
            blueCologne.SetActive(true);

            itemInstantiator.busy = true;
        }
        else
        {
            blueCologneOn = false;
            blueCologne.SetActive(false);

            itemInstantiator.busy = false;


        }
        if (blueCologneOn && Input.GetMouseButtonDown(1))
        {
            blueSpray.Play();
            //collider.enabled true
            cologneSpraySFX.Play(); 
        }
    }
}
