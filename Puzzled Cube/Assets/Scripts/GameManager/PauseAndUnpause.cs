using UnityEngine;

public class PauseAndUnpause : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pauseMenuUI;

     void Update() {
         if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                resume();
            }else{
                    pause();
                
            }
         }
    }
    public void pause(){
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
       
    }
    public void resume(){
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
            
    }
    public void loadMenu(){
        Debug.Log("loading menu");
    }
    public void quiteGame(){
        Debug.Log("quiting game");
        Application.Quit();
    }
}
