using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public Text CoinText;
    public int coins=0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        CoinText.text = "Coins : " + coins + "/8";
    }
}
