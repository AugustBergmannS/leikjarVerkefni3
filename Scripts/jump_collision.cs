using UnityEngine;

public class jump_collision : MonoBehaviour
{
    public FirstPersonAIO player;

    public void OnCollisionEnter(Collision collision)
    {
        player.grounded = true;
    }

}
