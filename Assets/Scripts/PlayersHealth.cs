using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayersHealth : MonoBehaviour
{
    public Animator animator;

    public GameObject healthBar;

    public GameObject player;

    private float currentLife;

    public float CurrentLife
    {
        get { return currentLife; }
        set
        {
            currentLife = value;
            RectTransform healthBarRectTransform = (RectTransform)healthBar.transform;
            healthBarRectTransform.sizeDelta = new Vector2(currentLife, healthBarRectTransform.sizeDelta.y);

            if(currentLife <= 0)
            {
                animator.SetBool("IsPlayerDead", true);
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    private void Start()
    {
        CurrentLife = 100f;
    }

    public void ReduceLifeByTag(string tag)
    {
        switch (tag)
        {
            case "Enemy":
                CurrentLife -= 40f;
                animator.SetTrigger("Hurt");
                break;
            default:
                break;
        }

    }

    public void ReduceLifeByWallTag(string tag)
    {
        switch (tag)
        {
            case "WallofDoom":
                CurrentLife -= 90f;
                animator.SetTrigger("Hurt");
                break;
            default:
                break;
        }

    }
}
