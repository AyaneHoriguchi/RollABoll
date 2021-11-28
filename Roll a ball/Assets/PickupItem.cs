using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{

    public SESoundManager SESoundManager;


    public float RollSpeed = 0.2f;
    private void Update()
    {
        //(0,1,0)
        this.gameObject.transform.Rotate(Vector3.up*RollSpeed, Space.World);

    }




    //Õ“Ë”»’è‚ğæ“¾‚µ‚Ü‚·
    private void OnCollisionEnter(Collision collision)
    {
        //‚à‚µÕ“Ë‚µ‚Ä‚«‚½‚Ì‚ªPlayer‚¾‚Á‚½‚ç
        if(collision.gameObject.tag.Equals("Player")){

            SESoundManager.PlayPickupItemSE();

            //©•ª‚ğÁ‚µ‚Ü‚·
            Destroy(this.gameObject);
        }
    }

}

