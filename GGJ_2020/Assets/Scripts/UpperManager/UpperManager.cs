﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class UpperManager : MonoBehaviour
{

    public List<RoomManager> Rooms = new List<RoomManager>();
    public GameObject Player1;
    public GameObject Player2;
    public float RunTime = 30;
    public bool started = false;
    private bool GameDone = false;
    
    public TextMeshProUGUI Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!started || GameDone)
            return;
        
        RunTime -= Time.deltaTime;

        Timer.text = RunTime.ToString("N2");

        if(RunTime <= 0){
            Debug.Log("Game over");
            GameDone = true;
            Player1.GetComponent<CharacterMovement>().enabled = false;
            Player2.GetComponent<CharacterMovement>().enabled = false;
        }

        if(Rooms.All(asd => asd.Done)){
            AllFixed();
            GameDone = true;
        }
    }
    

    public void AllFixed(){
        Debug.Log("You win");
    }
}
