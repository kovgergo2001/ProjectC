using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCraft : MonoBehaviour
{

    public void Check(Gamekit2D.DialogueCanvasController canvas)
    {
        string fileContents;
        bool key = false, engine = false;
        string saveFile = Application.persistentDataPath + "/gamedata";

        if (File.Exists(saveFile))
        {
            fileContents = File.ReadAllText(saveFile);

            key = (fileContents.Split(' ')[3] == "True");
            engine = (fileContents.Split(' ')[4] == "True");
        }
        else
        {
            File.WriteAllText(saveFile, "False False False False False");
        }

        if (key == true && engine == true)
        {
            canvas.ActivateCanvasWithText("I can leave!\n I won!");
        }
        else if (key != true)
        {
            canvas.ActivateCanvasWithText("I need a blue key");
        }
        else
        {
            canvas.ActivateCanvasWithText("Oh no! The engine is missing!\nMaybe it is underground, I should go and search for it!");
        }

    }
}