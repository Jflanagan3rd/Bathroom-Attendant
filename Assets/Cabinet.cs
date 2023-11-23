using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabinet : MonoBehaviour
{
    [SerializeField] Animator anim;

    bool cabdoorLeftOpen;
    bool cabdoorRightOpen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CabinetDoorLeftInteraction()
    {
        if (!cabdoorLeftOpen)
        { 
            anim.SetBool("openLeft", true);
            StartCoroutine("LeftTrueBoolDelay");
        }
        if (cabdoorLeftOpen)
        {
            anim.SetBool("openLeft", false);
            StartCoroutine("LeftFalseBoolDelay");
        }
    }

    IEnumerator LeftTrueBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        cabdoorLeftOpen = true;

    }
    IEnumerator LeftFalseBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        cabdoorLeftOpen = false;

    }

    public void CabinetDoorRightInteraction()
    {
        if (!cabdoorRightOpen)
        {
            anim.SetBool("openRight", true);
            StartCoroutine("RightTrueBoolDelay");
        }
        if (cabdoorRightOpen)
        {
            anim.SetBool("openRight", false);
            StartCoroutine("RightFalseBoolDelay");
        }
    }
    IEnumerator RightTrueBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        cabdoorRightOpen = true;

    }
    IEnumerator RightFalseBoolDelay()
    {
        yield return new WaitForSeconds(.1f);
        cabdoorRightOpen = false;

    }
}
