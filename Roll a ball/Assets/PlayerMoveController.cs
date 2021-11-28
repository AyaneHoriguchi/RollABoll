using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    //�v���C���[��Rigidbody   
    private Rigidbody playerRigidbody;

    public GameState GameState;
    public GameResultViewer GameResultViewer;




    public float Speed = 2f;
    //Start is calledbefore the first frame update
    void Start()
    {
      

           //�v���C���[��Rididbody���A�^�b�`����GameObject����擾���܂�
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



        //vector3�^�̕ϐ�move�Ɂi���E�L�[�C�O�C�㉺�L�[�j�̒l�������܂�
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //playerRigidbody��move�����̗͂������܂�
        playerRigidbody.AddForce(move*Speed);


    }
}
