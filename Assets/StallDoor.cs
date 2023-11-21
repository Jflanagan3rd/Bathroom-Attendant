using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StallDoor : MonoBehaviour, IInteractable
{
    [SerializeField] Animator anim;

    bool opened;
    public void Interact()
    {
        if (!opened)
        {
            anim.SetBool("open", true);
            StartCoroutine("TrueBoolDelay");

        }
        if (opened)
        {
            anim.SetBool("open", false);
            StartCoroutine("FalseBoolDelay");



        }
    }

    void Start()
    {
        anim.SetBool("open", false);
    }

    IEnumerator TrueBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        opened = true;
    }
    IEnumerator FalseBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        opened = false;
    }
}
