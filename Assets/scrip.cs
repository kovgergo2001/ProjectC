using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    string saveFile;

    Dictionary<string, bool> gameData = new Dictionary<string, bool>();


    void Start()
    {
        gameData.Add("purple", false);
        gameData.Add("green", false);
        gameData.Add("red", false);
        saveFile = Application.persistentDataPath + "/gamedata.json";
        if (!File.Exists(saveFile))
        {
            List<bool> helper = new List<bool>();
            foreach (var pair in gameData)
            {
                helper.Add(pair.Value);
            }
            string jsonString = helper[0].ToString() + " " + helper[1].ToString() + " " + helper[2].ToString();
            File.WriteAllText(saveFile, jsonString);
        }
        this.readFile();
        
    }

    public void readFile()
    {
        if (File.Exists(saveFile))
        {
            string fileContents = File.ReadAllText(saveFile);
       
            gameData["purple"] = (fileContents.Split(' ')[0] == "True");
            gameData["green"] = (fileContents.Split(' ')[1] == "True");
            gameData["red"] = (fileContents.Split(' ')[2] == "True");
        }
    }

    public void writeFile(string a)
    {
        gameData[a] = true;
        List<bool> helper = new List<bool>();
        Debug.Log(saveFile);
        if(gameData["red"])
        Debug.Log("nice");
        foreach (var pair in gameData)
        {
            helper.Add(pair.Value);
        }
        string jsonString = helper[0].ToString() + " " + helper[1].ToString() + " " + helper[2].ToString();
        Debug.Log(jsonString);
        File.WriteAllText(saveFile, jsonString);
    }

}
