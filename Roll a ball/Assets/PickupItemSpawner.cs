using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItemSpawner : MonoBehaviour
{
    public GameObject PickupItem;
    public int SpawnCount = 0;
    //public float SpawnCirclRadius = 3f;

    public List<Transform> SpawnPositions = new List<Transform>();

    public SESoundManager SESoundManager;


    void Awake()
    {

        //float radian = Mathf.PI * 2 / SpawnCount;

        for (int i = 0; i < SpawnPositions.Count; i++)
        {
            GameObject Pick = Instantiate(PickupItem);

            Pick.GetComponent<PickupItem>().SESoundManager = SESoundManager;

            Pick.transform.position = SpawnPositions[i].position;
            SpawnCount++;


            //Vector3 pos = Pick.transform.position;

            //pos.z = Mathf.Sin(radian * (i + 1)) * SpawnCirclRadius;
            //pos.x = Mathf.Cos(radian * (i + 1)) * SpawnCirclRadius;
            //Pick.transform.position = pos;





        }

    }
}
