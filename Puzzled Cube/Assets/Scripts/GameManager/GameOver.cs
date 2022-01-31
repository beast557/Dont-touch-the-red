using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public PlayerMovement playerMovement;
    bool gameHasEnded = false;
    public void gameOver(){
        if(gameHasEnded == false){
            StartCoroutine(SlowMotion());
            gameHasEnded = true;
            playerMovement.enabled = false;
            Debug.Log("dead");

        }
    }
    // private bool enableSlowMo = true;
 
 
 
 IEnumerator SlowMotion()
 {
     Time.timeScale = 0.5f;
    //  enableSlowMo = false;
 
     yield return new WaitForSeconds(2.5f);
 
     Time.timeScale = 1.0f;
 
     yield return new WaitForSeconds(5.0f);
 
    //  enableSlowMo = true;
 }
}
