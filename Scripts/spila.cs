using UnityEngine;
using UnityEngine.SceneManagement;


public class spila : MonoBehaviour
{
       public void ByrjaLeik()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



}
