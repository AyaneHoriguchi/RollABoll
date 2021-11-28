using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameResultViewer : MonoBehaviour
{
    public PlayerPickupItemManager PlayerPickupItemManager;
    public TextMeshProUGUI ResultText;
    public GameState GameState;
    public BGMSoundManager BGMSoundManager;



    private void Start()
    {
        ResultText.text = string.Empty;
    }

    private bool PlayedGameClearBGM = false;

    void Update()
    {
        if (PlayerPickupItemManager.GetAllPickupItems) {

            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            if(!PlayedGameClearBGM)
            {
                BGMSoundManager.PlayGameClearBGM();
                PlayedGameClearBGM = true;
            }

            ResultText.text = "Game Clear";
        }    
    }
}
