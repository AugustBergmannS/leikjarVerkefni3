
using UnityEngine;
using UnityEngine.UI;

public class creadits : MonoBehaviour
{
    public Text beentxt;
    int been = PlayerPrefs.GetInt("howManyBeens");


    void start()
    {
        SetCountText();
    }
    void SetCountText()
    {
        beentxt.text = "You got " + been.ToString() +" Beens!";
    }
    public void restart()
    {
        FindObjectOfType<GameManager>().tryagian();
    }
    public void quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
