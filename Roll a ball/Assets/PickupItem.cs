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




    //衝突判定を取得します
    private void OnCollisionEnter(Collision collision)
    {
        //もし衝突してきたのがPlayerだったら
        if(collision.gameObject.tag.Equals("Player")){

            SESoundManager.PlayPickupItemSE();

            //自分を消します
            Destroy(this.gameObject);
        }
    }

}

