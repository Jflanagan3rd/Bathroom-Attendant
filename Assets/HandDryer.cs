using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDryer : MonoBehaviour, IInteractable
{
    [SerializeField] AudioSource dryerSFX;
    [SerializeField] ParticleSystem dryerParts;

    bool dryerOn;

    [SerializeField] float dryerDuration;
    float dryerOnTime;

    private void Update()
    {
        if (dryerOn)
        {
            dryerOnTime += Time.deltaTime;
            if(dryerOnTime >= dryerDuration)
            {
                DryerOff();
                dryerOnTime = 0;
            }
        }
    }
    public void Interact()
    {
        if (dryerOn) { DryerOff(); StartCoroutine("FalseBoolDelay"); }
        if(!dryerOn) { DryerOn();  StartCoroutine("TrueBoolDelay"); }
    }

    public void DryerOn()
    {
        dryerParts.Play();
        dryerSFX.Play();

        dryerOn = true;
    }

    public void DryerOff()
    {
        dryerParts.Stop();
        dryerSFX.Stop();

        dryerOn = false;
    }

    IEnumerator TrueBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        dryerOn = true;
    }
    IEnumerator FalseBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        dryerOn = false;
    }
}
