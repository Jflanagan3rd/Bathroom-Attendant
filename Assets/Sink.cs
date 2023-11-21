using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject water;

    bool waterOn;
    public void Interact()
    {
        if (!waterOn)
        {
            water.SetActive(true);
            StartCoroutine("TrueBoolDelay");

        }
        if (waterOn)
        {
            water.SetActive(false);
            StartCoroutine("FalseBoolDelay");

        }
    }

    IEnumerator TrueBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        waterOn = true;
    }
    IEnumerator FalseBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        waterOn = false;
    }
}
