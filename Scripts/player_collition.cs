using UnityEngine;
using UnityEngine.UI;


public class player_collition : MonoBehaviour
{
    public int bean = 0;
    float current = 0f;
    public Text countText;
    int nrOfbeans = 0;
    public GameObject DoorTrigger;
    public AudioSource sounds;
    public AudioClip oof;
    public AudioClip beansa;

    void Start()
    {
        GameObject[] beans;
        beans = GameObject.FindGameObjectsWithTag("bean");
        nrOfbeans = beans.Length;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstical") 
        {
            sounds.PlayOneShot(oof,1);
            if (current <= 0f)
            {
                bean -= 1;
                nrOfbeans -= 1;
                countText.text = "" + bean.ToString();
            }
            current = 2f;
            
            if (bean < 0)
            {
                bean = 0;
                PlayerPrefs.SetInt("howManyBeans", bean);
                FindObjectOfType<GameManager>().loadnxtlvl();
            }
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bean"))
        {
            sounds.PlayOneShot(beansa, 1);
            other.gameObject.SetActive(false);
            bean = bean + 1;
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
        countText.text = "" + bean.ToString();

        if (bean >= nrOfbeans)
        {
            PlayerPrefs.SetInt("howManyBeans", bean);
            FindObjectOfType<GameManager>().loadnxtlvl();
        }
    }
    

    void Update()
    {
        current -= 1 * Time.deltaTime;
    }
}
