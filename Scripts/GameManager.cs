using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
    {

        public float restartDelay = 0.4f;
        
        bool gameHasEnded = false;

        public void loadnxtlvl()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        public void EndGame()
        {
            if (gameHasEnded == false)
            {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
            }    
        }
        public void tryagian()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
