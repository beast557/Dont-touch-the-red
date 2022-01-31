using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void restartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
