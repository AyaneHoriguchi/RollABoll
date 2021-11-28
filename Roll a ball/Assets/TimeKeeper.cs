using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class TimeKeeper : MonoBehaviour
{
    public TextMeshProUGUI TimeText;
    public GameResultViewer GameResultViewer;
    public float TimeLimit = 20f;

    public GameState GameState;

    public void Update()
    {
        if(GameState.GameProgressState == GameState.GameProgressStates.GameResult)
        {
            return;

        }



        if (TimeLimit > 0 && !GameResultViewer.PlayerPickupItemManager.GetAllPickupItems)
        {
            TimeLimit -= Time.deltaTime;
            TimeText.text = $"{(int)TimeLimit + 1}";


        }

        else if (GameResultViewer.PlayerPickupItemManager.GetAllPickupItems)
        {
            TimeText.text = $"{(int)TimeLimit + 1}";
        }
        else
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            TimeText.text = $"{0}";
            GameResultViewer.ResultText.text = "Game Over";
        }

    }

       

}
