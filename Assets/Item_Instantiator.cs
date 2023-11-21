using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Instantiator : MonoBehaviour
{
    [SerializeField] GameObject toiletPaper;
    [SerializeField] GameObject itemOrigin;
    [SerializeField] float coolDownTime;
    float coolDownTimer;

    bool coolDown;

    [SerializeField] AudioSource TP_SFX;

    public bool busy;
    void Start()
    {
        
    }

    void Update()
    {
        if (!busy)
        {
            if (Input.GetMouseButtonDown(1) && !coolDown)
            {
                coolDown = true;
                Instantiate(toiletPaper, itemOrigin.transform.position, itemOrigin.transform.rotation);
                TP_SFX.Play();


            }
            if (coolDown)
            {
                coolDownTimer += Time.deltaTime;
                if (coolDownTimer >= coolDownTime)
                {
                    coolDownTimer = 0;
                    coolDown = false;
                }
            }
        }
      
     
    }
}
