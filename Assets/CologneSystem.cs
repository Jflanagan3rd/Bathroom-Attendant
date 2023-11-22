using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CologneSystem : MonoBehaviour
{
    [SerializeField] GameObject blueCologne;
    [SerializeField] GameObject pinkCologne;
    [SerializeField] GameObject yellowCologne;
    [SerializeField] GameObject orangeCologne;


    [SerializeField] ParticleSystem blueSpray;
    [SerializeField] ParticleSystem yellowSpray;
    [SerializeField] ParticleSystem orangeSpray;
    [SerializeField] ParticleSystem pinkSpray;



    [SerializeField] AudioSource cologneSpraySFX;

    public bool blueCologneOn;
    public bool pinkCologneOn;
    public bool yellowCologneOn;
    public bool orangeCologneOn;


    Item_Instantiator itemInstantiator;

    void Start()
    {
        itemInstantiator = FindObjectOfType<Item_Instantiator>();
    }

    void Update()
    {      
        BlueCologne();
        PinkCologne();
        YellowCologne();
        OrangeCologne();
    
    }

    public void BlueCologne()
    {
        if (blueCologneOn)
        {
            blueCologne.SetActive(true);

           
        }
        else
        {
            blueCologneOn = false;
            blueCologne.SetActive(false);

        }
        if (blueCologneOn && Input.GetMouseButtonDown(1))
        {
            blueSpray.Play();
            //collider.enabled true
            cologneSpraySFX.Play();
        }
    }
    public void PinkCologne()
    {
        if (pinkCologneOn)
        {
            pinkCologne.SetActive(true);

            itemInstantiator.busy = true;
        }
        else
        {
            pinkCologneOn = false;
            pinkCologne.SetActive(false);

        }
        if (pinkCologneOn && Input.GetMouseButtonDown(1))
        {
            pinkSpray.Play();
            //collider.enabled true
            cologneSpraySFX.Play();
        }
    }
    public void YellowCologne()
    {
        if (yellowCologneOn)
        {
            yellowCologne.SetActive(true);

            itemInstantiator.busy = true;
        }
        else
        {
            yellowCologneOn = false;
            yellowCologne.SetActive(false);

            itemInstantiator.busy = false;
        }
        if (yellowCologneOn && Input.GetMouseButtonDown(1))
        {
            yellowSpray.Play();
            //collider.enabled true
            cologneSpraySFX.Play();
        }
    }
    public void OrangeCologne()
    {

        if (orangeCologneOn)
        {
            orangeCologne.SetActive(true);

            itemInstantiator.busy = true;
        }
        else
        {
            orangeCologneOn = false;
            orangeCologne.SetActive(false);

            itemInstantiator.busy = false;
        }
        if (orangeCologneOn && Input.GetMouseButtonDown(1))
        {
            orangeSpray.Play();
            //collider.enabled true
            cologneSpraySFX.Play();
        }
    }
}
