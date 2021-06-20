using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savings : MonoBehaviour
{
    string saveFile;

    Dictionary<string, bool> gameData = new Dictionary<string, bool>(){
    {"purple", false},
    {"green", false},
    {"red", false}
    };


    void Start()
    {
        saveFile = Application.persistentDataPath + "/gamedata.json";
        if (File.Exists(saveFile))
        {
            string jsonString = JsonUtility.ToJson(gameData);
            File.WriteAllText(saveFile, jsonString);
        }
        this.readFile();
        Debug.Log("asd");
    }

    public void readFile()
    {
        if (File.Exists(saveFile))
        {
            string fileContents = File.ReadAllText(saveFile);

            gameData = JsonUtility.FromJson<Dictionary<string, bool>>(fileContents);
        }
    }

    public void writeFile(string a)
    {
        gameData[a] = true;
        string jsonString = JsonUtility.ToJson(gameData);

        File.WriteAllText(saveFile, jsonString);
    }

    void Update()
    {
        Debug.Log("asd");
    }
}