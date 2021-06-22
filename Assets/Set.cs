using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set : MonoBehaviour
{
    public void Load()
    {
        string saveFile = Application.persistentDataPath + "/level1";
        File.WriteAllText(saveFile, "False");

        saveFile = Application.persistentDataPath + "/level2";
        File.WriteAllText(saveFile, "False");

        saveFile = Application.persistentDataPath + "/gamedata";
        File.WriteAllText(saveFile, "False False False False False");
    }
}
