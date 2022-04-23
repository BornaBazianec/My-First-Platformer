using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public game g;
    public AudioClip coinSound;
    // Start is called before the first frame update
    void Start()
    {
        g = GameObject.Find("Canvas").GetComponent<game>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    private void OnTriggerEnter(Collider other)
    {
        g.coins++;
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        Destroy(gameObject);
    }
}
