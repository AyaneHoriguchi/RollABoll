using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupItemManager : MonoBehaviour
{
    public PickupItemSpawner PickupItemSpawner;
    
    public int PickupItemCount = 0;
    public int PickupItemSpawnCount = 0;
    public bool GetAllPickupItems = false;

    public GameState GameState;


    private void Start()
    {
        PickupItemSpawnCount = PickupItemSpawner.SpawnCount;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;
        }



        if(collision.gameObject.tag.Equals("PickupItem"))
        {
            PickupItemCount++;
            if(PickupItemCount == PickupItemSpawnCount)
            {
                GetAllPickupItems = true;
                GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);

            }
        }
    }
}
