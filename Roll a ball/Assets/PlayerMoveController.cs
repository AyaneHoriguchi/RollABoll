using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    //プレイヤーのRigidbody   
    private Rigidbody playerRigidbody;

    public GameState GameState;
    public GameResultViewer GameResultViewer;




    public float Speed = 2f;
    //Start is calledbefore the first frame update
    void Start()
    {
      

           //プレイヤーのRididbodyをアタッチしたGameObjectから取得します
           playerRigidbody = GetComponent<Rigidbody>();
  
    }
    //Update is caled once per frame
    void Update()
    {
        if(this.transform.position.y < -1)
        {
            GameState.SetGameProgressState(GameState.GameProgressStates.GameResult);
            GameResultViewer.ResultText.text = "Game Over";
            return;


        }



        //vector3型の変数moveに（左右キー，０，上下キー）の値を代入します
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //playerRigidbodyにmove向きの力を加えます
        playerRigidbody.AddForce(move*Speed);


    }
}
