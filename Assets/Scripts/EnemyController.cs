using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject HUD;

    private void OnTriggerEnter(Collider collideObject)
    {
       if (collideObject.tag == "Player")
        {
            HUD.GetComponent<PlayersHealth>().ReduceLifeByTag(this.tag);
        }
    }
}
