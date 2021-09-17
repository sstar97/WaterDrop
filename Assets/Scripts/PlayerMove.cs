using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 0.5f;

    public GameObject player;

    private Rigidbody2D playerBody;
    private float ScreenWidth;

    public Vector3 vec =new Vector3(2.59f, 3, 0);

    void Start()
    {
        ScreenWidth = Screen.width;
        playerBody = player.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        int i = 0;
        while (i< Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                movePlayer(1.0f);
            }

            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                movePlayer(-1.0f);
            }
            i++;
        }
    }

    private void FixedUpdate()
    {
#if UNITY_EDITOR
        movePlayer(Input.GetAxis("Horizontal"));
#endif
    }

    private void movePlayer(float horizontalInput)
    {
        if (PlayerPrefs.GetInt("life") > 0)
        {
            //playerBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));

            player.transform.Translate(Time.deltaTime * moveSpeed * horizontalInput, 0, 0);
            if (player.transform.position.x > 2.62)
            {
                player.transform.position = new Vector3(2.59f, 3, 0);
            }
            if (player.transform.position.x < -2.62)
            {
                player.transform.position = new Vector3(-2.59f, 3, 0);
            }
        }
    }
}
