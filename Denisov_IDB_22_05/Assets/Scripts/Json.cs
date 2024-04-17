using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Analytics;
[Serializable]
public class Player
{
    public int Score;
    public Player(int score)
    {
        Score = score;
    }
}

public class Json : MonoBehaviour
{
    public Text score;
    private string path = "C://Users//Maks//Desktop//Unity Project//Denisov_IDB2205//Denisov_IDB_22_05//Assets//Scripts//jsonFile.txt";
    private Player player = null;
    void Start()
    {
        StreamReader reader = new StreamReader(path);
        string a = reader.ReadLine();
        print(a);
        if(a != null)
            player = JsonUtility.FromJson<Player>(a);
        else
            player = new Player(0);
        score.text = Convert.ToString(player.Score);

        reader.Close();
    }
    public void OnDisable()
    {
        player.Score = Convert.ToInt32(score.text);
        string playerJson = JsonUtility.ToJson(player);
        StreamWriter writer = new StreamWriter(path, false);
        writer.Write(playerJson);
        writer.Close();
    }
}

