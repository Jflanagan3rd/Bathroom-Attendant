using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapDispenser : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject full;
    [SerializeField] GameObject threefull;
    [SerializeField] GameObject halffull;
    [SerializeField] GameObject quarterfull;

    public bool empty;

    [SerializeField]  int totalPumps;
    public int pumpsLeft;

    [SerializeField] float timer;
    public float time;
    void Start()
    {
        pumpsLeft = totalPumps;
    }

    // Update is called once per frame
    void Update()
    {
        //if(empty){ icon.SetActive(true);}

        if(pumpsLeft <= totalPumps * .75) { ThreeFull(); }
        if (pumpsLeft <= totalPumps * .50) { HalfFull(); }
        if (pumpsLeft <= totalPumps * .25) { QuarterFull(); }
        if (pumpsLeft <= 0) { Empty(); }

        time += Time.deltaTime;
        if(time >= timer)
        {
            time = 0;
        }
        if(time >= 3) { pumpsLeft = 6; }
        if (time >= 6) { pumpsLeft = 4; }
        if (time >= 9) { pumpsLeft = 2; }
        if (time >= 12) { pumpsLeft = 0; }


    }

    public void ThreeFull()
    {
        full.SetActive(false);
    }
    public void HalfFull()
    {
        threefull.SetActive(false);
    }
    public void QuarterFull()
    {
        halffull.SetActive(false);
    }
    public void Empty()
    {
        quarterfull.SetActive(false);
        empty = true;
    }

    public void Interact()
    {
        if (empty)
        {
            full.SetActive(true);
            threefull.SetActive(true);
            halffull.SetActive(true);
            quarterfull.SetActive(true);

            empty = false;
            pumpsLeft = totalPumps;
            time = 0;
        }
    }
}
