using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] GameObject PanelEnd;
    [SerializeField] AudioClip clipDefeat;
    [SerializeField] AudioSource audioSource;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            audioSource.PlayOneShot(clipDefeat);

            Time.timeScale = 0f;
            PanelEnd.SetActive(true);
        }
    }

    [System.Obsolete]
    private void Update()
    {
        if(transform.position.y <= -6 && PanelEnd.active != true)
        {
            audioSource.PlayOneShot(clipDefeat);

            Time.timeScale = 0f;
            PanelEnd.SetActive(true);
        }
    }
}