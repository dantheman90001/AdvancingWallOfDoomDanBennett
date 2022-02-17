using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOfDeath : MonoBehaviour
{
    float speedanonymousultiplier = 0.6f;
 
  void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speedanonymousultiplier);
    }

    public GameObject HUD;

    private void OnTriggerEnter(Collider collideObject)
    {
        if (collideObject.tag == "Player")
        {
            HUD.GetComponent<PlayersHealth>().ReduceLifeByWallTag(this.tag);
        }
    }
}
