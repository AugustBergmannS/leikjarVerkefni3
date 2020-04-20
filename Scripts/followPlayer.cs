using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class followPlayer : MonoBehaviour
{
    public Transform Player;
    public int MoveSpeed = 10;
    float MinDist = 0.6f;



   void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;


        }
    }
}
