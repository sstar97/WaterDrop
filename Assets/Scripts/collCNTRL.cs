using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class collCNTRL : MonoBehaviour
{
    public Text heal;
    public GameObject menu,pauseMenu,settingsMenu,plyBtn,tutorial;
    public int health,addsay, spriteControl;
    private float say;

    public Sprite poison, lava, oil, crystal, water;
    SpriteRenderer spriteRenderer;

    public AudioClip crush;
    public AudioClip hp;

    private AudioSource audioSource;
    void Start()
    {
        

        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        spriteControl = PlayerPrefs.GetInt("iconTag");
        audioSource = GetComponent<AudioSource>();

        menu.SetActive(false);
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(false);

        Debug.Log(spriteControl);

        PlayerPrefs.SetInt("life", 3);
        PlayerPrefs.SetInt("addsay", 0);
        addsay = PlayerPrefs.GetInt("addsay");
        health = PlayerPrefs.GetInt("life");

        tutorial.SetActive(true);
        if(spriteControl == 0)
        {
            spriteRenderer.sprite = water;
        }
        if (spriteControl == 1)
        {
            spriteRenderer.sprite = poison;
        }
        if (spriteControl == 2)
        {
            spriteRenderer.sprite = lava;
        }
        if (spriteControl == 3)
        {
            spriteRenderer.sprite = oil;
        }
        if (spriteControl == 4)
        {
            spriteRenderer.sprite = crystal;
        }
    }

    private void Update()
    {
        say = Time.deltaTime + say;
        if (say > 3f)
        {
            tutorial.SetActive(false);
        }
        if (menu.activeSelf == true)
        {
            pauseMenu.SetActive(false);
        }

        if (PlayerPrefs.GetInt("add") == 0)
        {
            plyBtn.SetActive(false);
        }
        else
        {
            plyBtn.SetActive(true);
        }

        health = PlayerPrefs.GetInt("life");
        heal.text = Convert.ToString(health);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "enemy"||coll.gameObject.tag=="tree")
        {
            health = PlayerPrefs.GetInt("life") - 1;
            coll.gameObject.SetActive(false);
            PlayerPrefs.SetInt("life", health);
            heal.text = Convert.ToString(health);
            this.gameObject.transform.localScale = new Vector2(this.gameObject.transform.localScale.x - 0.04f, this.gameObject.transform.localScale.y - 0.04f);
            addsay = addsay + 1;
            PlayerPrefs.SetInt("addsay",addsay);

            audioSource.PlayOneShot(crush);
        }

        if (health <= 0)
        {
            PlayerPrefs.SetInt("key", 0);
            menu.SetActive(true);
            Debug.Log(addsay);
            if (addsay == 3)
            {
                GameObject.FindGameObjectWithTag("add").GetComponent<addScript>().ShowAdd();
                PlayerPrefs.SetInt("addsay", 0);
                
            }
            PlayerPrefs.SetInt("moneySay", 1);
        }
        else
        {
            PlayerPrefs.SetInt("moneySay", 0);
            PlayerPrefs.SetInt("key", 1);
            menu.SetActive(false);
        }

        if (coll.gameObject.tag == "health")
        {
            health = health + 1;
            coll.gameObject.SetActive(false);
            PlayerPrefs.SetInt("life", health);
            heal.text = Convert.ToString(health);
            this.gameObject.transform.localScale = new Vector2(this.gameObject.transform.localScale.x + 0.04f, this.gameObject.transform.localScale.y + 0.04f);
            addsay = PlayerPrefs.GetInt("addsay" , -1);
            PlayerPrefs.SetInt("addsay", addsay);

            audioSource.PlayOneShot(hp);
        }
    }
}
