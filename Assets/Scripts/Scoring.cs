using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    public int TotalScore;
    public Slider AudienceSlider;

    private void Update() {

        
        
    }

    private void OnTriggerEnter(Collider other) {
        
        if (other.tag == "Player")
        {
            TotalScore = TotalScore + 10;
        }

        if (other.tag == "Obstical")
        {
            TotalScore = TotalScore - 5;
        }
    }
}
