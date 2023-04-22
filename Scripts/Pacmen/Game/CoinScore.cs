using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    [SerializeField] Text score;
    int coin;
    [SerializeField] AudioClip coinClip;
    [SerializeField] AudioSource coinSource;
    // Start is called before the first frame update
    void Start()
    {
        coin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            coin += 50;
            score.text = "Score: " + coin.ToString();

            coinSource.PlayOneShot(coinClip);

            Destroy(collision.gameObject);
        }
    }
}
