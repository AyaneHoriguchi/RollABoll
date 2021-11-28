using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    public Transform TargetPlayer;
    public GameResultViewer GameResultViewer;
    private NavMeshAgent navMeshAgent;

    public GameState GameState;

        
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        navMeshAgent.SetDestination(TargetPlayer.transform.position);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            GameResultViewer.ResultText.text = "Game Over";
            return;




        }
    }

}
