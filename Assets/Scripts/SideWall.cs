using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if (hitInfo.name == "Ball")
        {
            hitInfo.gameObject.SendMessage("RestartGame");
            GameManager.instance.Score(gameObject.name);
        }
    }
}