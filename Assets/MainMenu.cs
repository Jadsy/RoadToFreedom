using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
     public void playGame(){

         Invoke("startGame",2);

     }

     public void startGame(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
     }

     public void quitGame(){
         Debug.Log("Exited");
         Application.Quit();
     }
}
