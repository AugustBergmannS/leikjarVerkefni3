using UnityEngine;
using UnityEngine.UI;


public class player_collition : MonoBehaviour
{
    public int been = 0;
    float current = 0f;
    public Text countText;
    int nrOfbeens = 0;
    public GameObject DoorTrigger;
    //public
    


    void Start()
    {
        GameObject[] beens;
        beens = GameObject.FindGameObjectsWithTag("been");
        nrOfbeens = beens.Length;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstical") 
        {
            if (current <= 0f)
            {
                been -= 1;
                nrOfbeens -= 1;
            }
            current = 2f;
            
            if (been < 0)
            {
                PlayerPrefs.SetInt("howManyBeens", been);
                FindObjectOfType<GameManager>().loadnxtlvl();
            }
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("been"))
        {
            other.gameObject.SetActive(false);
            been = been + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("pressure plate"))
        {
            other.gameObject.SetActive(false);
            DoorTrigger.SetActive(false);
        }
    }
    void SetCountText()
    {
        countText.text = "" + been.ToString();

        if (been >= nrOfbeens)
        {
            PlayerPrefs.SetInt("howManyBeens",been);
            FindObjectOfType<GameManager>().loadnxtlvl();
        }
    }
    

    void Update()
    {
        current -= 1 * Time.deltaTime;
    }
}
