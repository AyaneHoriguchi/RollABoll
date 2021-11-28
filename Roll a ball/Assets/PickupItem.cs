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




    //�Փ˔�����擾���܂�
    private void OnCollisionEnter(Collision collision)
    {
        //�����Փ˂��Ă����̂�Player��������
        if(collision.gameObject.tag.Equals("Player")){

            SESoundManager.PlayPickupItemSE();

            //�����������܂�
            Destroy(this.gameObject);
        }
    }

}

