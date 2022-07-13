using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    public int TotalGameScore;
    public Slider AudienceSlider;
    public GameObject CheckOrigin;
    public GameObject Checkpoint1;
    public GameObject Checkpoint2;
    public GameObject CurrentCheckpoint;

    private void Start() {

        CheckPoints();
        transform.position = CurrentCheckpoint.transform.position;
    }
   
    private void Update() 
    {
        CheckPoints();
        AudienceSlider.value = TotalGameScore;
    }

    private void OnTriggerEnter(Collider other) {
        
        if (other.tag == "Hoop")
        {
            TotalGameScore = TotalGameScore + 10;
        }

        if (other.tag == "Obstical")
        {
            TotalGameScore = TotalGameScore - 5;
            transform.position = CurrentCheckpoint.transform.position;
        }
    }

    void Onend() 
    {
        if (TotalGameScore == 150)
        {
            SceneManager.LoadScene("MainLobby");  
        }
    }

    void CheckPoints(){

        if(TotalGameScore == 0)
        {
            CurrentCheckpoint = CheckOrigin;  
        }
        
        if(TotalGameScore == 50)
        {
            CurrentCheckpoint = Checkpoint1;  
        }

        if(TotalGameScore == 100)
        {
            CurrentCheckpoint = Checkpoint2;     
        }

    }
}
