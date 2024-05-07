using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class HighScoreControl : MonoBehaviour
{
    private string secretKey = "mySecretKey";
    public string addScoreURL =
            "http://localhost/harmsen/addscore.php";
    public string highscoreURL =
             "http://localhost/harmsen/display.php";
    public Text nameTextInput;
    public Text scoreTextInput;
    public Text nameResultText;
    public Text scoreResultText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
