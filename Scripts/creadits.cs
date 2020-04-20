
using UnityEngine;
using UnityEngine.UI;

public class creadits : MonoBehaviour
{
    public Text beantxt;
    int bean = PlayerPrefs.GetInt("howManyBeans");


    void start()
    {
        SetCountText();
    }
    void SetCountText()
    {
        beantxt.text = "You got " + bean.ToString() + " Beans!";
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
