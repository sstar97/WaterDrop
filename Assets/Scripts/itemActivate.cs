using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class itemActivate : MonoBehaviour
{
    public PlayerPrefs iconTag, money,pb;
    public GameObject target1, target2, target3, target4,marketCoin;
    int coin;
    int poisonBuy,lavaBuy,oilBuy,crystalBuy;
    public void Start()
    {
        poisonBuy = PlayerPrefs.GetInt("pb");
        lavaBuy = PlayerPrefs.GetInt("lb");
        oilBuy = PlayerPrefs.GetInt("ob");
        crystalBuy = PlayerPrefs.GetInt("cb");

        coin = PlayerPrefs.GetInt("money");
        marketCoin.GetComponent<UnityEngine.UI.Text>().text = coin.ToString();
        if (poisonBuy == 1)
        {
            target1.SetActive(false);
        }

        if (lavaBuy == 1)
        {
            target2.SetActive(false);
        }

        if (oilBuy == 1)
        {
            target3.SetActive(false);
        }
        if (crystalBuy == 1)
        {
            target4.SetActive(false);
        }
    }

    public void Update()
    {
        coin = PlayerPrefs.GetInt("money");
        marketCoin.GetComponent<UnityEngine.UI.Text>().text = coin.ToString();
    }

    public void poisonChange()
    {
        if (coin >= 100 & poisonBuy == 0)
        {
            PlayerPrefs.SetInt("money", coin - 100);
            PlayerPrefs.SetInt("iconTag", 1);
            this.gameObject.SetActive(false);
            poisonBuy = 1;
            PlayerPrefs.SetInt("pb", poisonBuy);
            coin = PlayerPrefs.GetInt("money");
            marketCoin.GetComponent<UnityEngine.UI.Text>().text = coin.ToString();

            target1.SetActive(false);
        }
        if (poisonBuy == 1)
        {
            PlayerPrefs.SetInt("iconTag", 1);
            target1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("iconTag") != 1)
        {
            this.gameObject.SetActive(true);
        }
    }

    public void lavaChange()
    {
        
        if (coin >= 200 & lavaBuy == 0)
        {
            PlayerPrefs.SetInt("money", coin - 200);
            PlayerPrefs.SetInt("iconTag", 2);
            this.gameObject.SetActive(false);
            lavaBuy = 1;
            PlayerPrefs.SetInt("lb", lavaBuy);
            coin = PlayerPrefs.GetInt("money");
            marketCoin.GetComponent<UnityEngine.UI.Text>().text = coin.ToString();

            target2.SetActive(false);
        }
        if (lavaBuy == 1)
        {
            PlayerPrefs.SetInt("iconTag", 2);
            target2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("iconTag") != 2)
        {
            this.gameObject.SetActive(true);
        }
    }

    public void oilChange()
    {
        if (coin >= 500 & oilBuy == 0)
        {
            PlayerPrefs.SetInt("money", coin - 500);
            PlayerPrefs.SetInt("iconTag", 3);
            this.gameObject.SetActive(false);
            oilBuy = 1;
            PlayerPrefs.SetInt("ob", oilBuy);
            coin = PlayerPrefs.GetInt("money");
            marketCoin.GetComponent<UnityEngine.UI.Text>().text = coin.ToString();

            target3.SetActive(false);
        }
        if (oilBuy == 1)
        {
            PlayerPrefs.SetInt("iconTag", 3);
            target3.SetActive(false);
        }
        if(PlayerPrefs.GetInt("iconTag") != 3)
        {
            this.gameObject.SetActive(true);
        }
    }

    public void crystalChange()
    {
        if (coin >= 1500 & crystalBuy == 0)
        {
            PlayerPrefs.SetInt("money", coin - 1500);
            PlayerPrefs.SetInt("iconTag", 4);
            this.gameObject.SetActive(false);
            crystalBuy = 1;
            PlayerPrefs.SetInt("cb", crystalBuy);
            coin = PlayerPrefs.GetInt("money");
            marketCoin.GetComponent<UnityEngine.UI.Text>().text = coin.ToString();

            target4.SetActive(false);
        }
        if (crystalBuy == 1)
        {
            PlayerPrefs.SetInt("iconTag", 4);
            target4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("iconTag") != 4)
        {
            this.gameObject.SetActive(true);
        }
    }


    public void backButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
