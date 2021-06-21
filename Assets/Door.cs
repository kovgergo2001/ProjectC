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
    private bool redDoor = false;
    private bool greenDoor = false;
    private bool purpleDoor = false;
    public void checkRed(Gamekit2D.DialogueCanvasController canvas)
    {
        if(!redDoor)
        {
            if (File.Exists(saveFile))
            {
                string fileContents = File.ReadAllText(saveFile);

                gameData["purple"] = (fileContents.Split(' ')[0] == "True");
                gameData["green"] = (fileContents.Split(' ')[1] == "True");
                gameData["red"] = (fileContents.Split(' ')[2] == "True");

                if (gameData["red"] == true)
                {
                    canvas.ActivateCanvasWithText("I have a key that fits!");
                    door.GetComponent<Animator>().Play("DoorOpening");
                    redDoor = true;
                }
                else
                {
                    canvas.ActivateCanvasWithText("I need a red key to open this door");
                }
            }
        }
    }

    public void checkPurple(Gamekit2D.DialogueCanvasController canvas)
    {
        if (!purpleDoor)
        {
            if (File.Exists(saveFile))
            {
                string fileContents = File.ReadAllText(saveFile);

                gameData["purple"] = (fileContents.Split(' ')[0] == "True");
                gameData["green"] = (fileContents.Split(' ')[1] == "True");
                gameData["red"] = (fileContents.Split(' ')[2] == "True");

                if (gameData["purple"] == true)
                {
                    canvas.ActivateCanvasWithText("I have a key that fits!");
                    door.GetComponent<Animator>().Play("DoorOpening");
                    purpleDoor = true;
                }
                else
                {
                    canvas.ActivateCanvasWithText("I need a purple key to open this door");
                }
            }
        }
    }

    public void checkGreen(Gamekit2D.DialogueCanvasController canvas)
    {
        if (!greenDoor)
        {
            if (File.Exists(saveFile))
            {
                string fileContents = File.ReadAllText(saveFile);

                gameData["purple"] = (fileContents.Split(' ')[0] == "True");
                gameData["green"] = (fileContents.Split(' ')[1] == "True");
                gameData["red"] = (fileContents.Split(' ')[2] == "True");

                if (gameData["green"] == true)
                {
                    canvas.ActivateCanvasWithText("I have a key that fits!");
                    door.GetComponent<Animator>().Play("DoorOpening");
                    greenDoor = true;
                }
                else
                {
                    canvas.ActivateCanvasWithText("I need a green key to open this door");
                }
            }
        }
    }
}
