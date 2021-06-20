using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Dictionary<string, bool> gameData = new Dictionary<string, bool>(){
    {"purple", false},
    {"green", false},
    {"red", false}
    };
    public GameObject door;
    private string saveFile;
    void Start() {
        saveFile = Application.persistentDataPath + "/gamedata.json";
    }

    public void checkRed()
    {
        if (File.Exists(saveFile))
        {
            string fileContents = File.ReadAllText(saveFile);

            gameData["purple"] = (fileContents.Split(' ')[0] == "True");
            gameData["green"] = (fileContents.Split(' ')[1] == "True");
            gameData["red"] = (fileContents.Split(' ')[2] == "True");

            if (gameData["red"] == true)
            {
                door.GetComponent<Animator>().Play("DoorOpening");
            }
        }
    }

    public void checkPurple()
    {
        if (File.Exists(saveFile))
        {
            string fileContents = File.ReadAllText(saveFile);

            gameData["purple"] = (fileContents.Split(' ')[0] == "True");
            gameData["green"] = (fileContents.Split(' ')[1] == "True");
            gameData["red"] = (fileContents.Split(' ')[2] == "True");

            if (gameData["purple"] == true)
            {
                door.GetComponent<Animator>().Play("DoorOpening");
            }
        }
    }

    public void checkGreen()
    {
        if (File.Exists(saveFile))
        {
            string fileContents = File.ReadAllText(saveFile);

            gameData["purple"] = (fileContents.Split(' ')[0] == "True");
            gameData["green"] = (fileContents.Split(' ')[1] == "True");
            gameData["red"] = (fileContents.Split(' ')[2] == "True");

            if (gameData["green"] == true)
            {
                door.GetComponent<Animator>().Play("DoorOpening");
            }
        }
    }
}
