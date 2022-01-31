using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float restartDelay = 1f;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="Enemy"){
            FindObjectOfType<GameOver>().gameOver();
            Invoke("callRestartLevel",restartDelay);
        }
        if(other.gameObject.tag=="Friend"){
            FindObjectOfType<LevelWon>().levelWon();
        }   
    }
void callRestartLevel(){
        FindObjectOfType<RestartLevel>().restartLevel();
    }
    
}
