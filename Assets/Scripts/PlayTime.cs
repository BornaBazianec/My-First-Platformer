using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTime : MonoBehaviour
{
    public int playtime = 0;
    private int seconds = 0;
    private int minutes = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("PlayTimer");
    }
    private IEnumerator PlayTimer()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            playtime+=1;
            seconds = (playtime % 60);
            minutes = (playtime / 60) % 60;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
