using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TentBehaviour : MonoBehaviour
{
       private void OnTriggerEnter(Collider other) {
        
        if (other.tag == "Europe")
        {
            SceneManager.LoadScene("GameEurope"); 
        }

        if (other.tag == "Asia")
        {
            SceneManager.LoadScene("GameAsia");
        }

        if (other.tag == "America")
        {
            SceneManager.LoadScene("GameAmerica");       
        }
    }
}
