using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRunnerMovement : MonoBehaviour
{
    bool lane1;
    bool lane2;
    bool lane3;
    public GameObject _player;

    void Start()
    {
        lane1 = false;
        lane2 = true;
        lane3 = false;
       //_player.transform.Translate(-1.01f, 1.01f, 0f);
    }
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if(Input.GetKeyDown(KeyCode.D) && lane1 == false && lane3 == false)
        { 
            transform.Translate(0, 0, 2);
            lane3 = true;
            lane2 = false;
        }    
        if(Input.GetKeyDown(KeyCode.A) && lane1 == true && lane2 == false)
        {
            transform.Translate(0, 0, -2);
            lane1 = true;
            lane2 = false;
        }
        if(Input.GetKeyDown(KeyCode.D) && lane1 == true && lane2 == false)
        {
            transform.Translate(0, 0, 2);
            lane2 = true;
            lane1 = false;
        }
        if(Input.GetKeyDown(KeyCode.A) && lane2 == true && lane3 == false)
        {
            transform.Translate(0, 0, -2);
            lane2 = true;
            lane3 = false;
        }
    }
}
