using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject shit;
    [SerializeField] Animator anim;
    [SerializeField] AudioSource flushSFX;

    public bool flushing;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (shit && !flushing)
        {
            
            anim.SetBool("flush", true);
            flushSFX.Play();
            flushing = true;
            StartCoroutine("RefillBowl");
        }
    }

    public void Pooped()
    {
        shit.SetActive(true);
    }
  

    void Update()
    {
        
    }

    IEnumerator RefillBowl()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("flush", false);
        yield return new WaitForSeconds(4);
        flushing = false;
    }
}
