using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class EnginePickUp : MonoBehaviour
{
    // Start is called before the first frame update
    public new GameObject gameObject;
    void Start()
    {
        string saveFile = Application.persistentDataPath + "/level2";
        if(File.Exists(saveFile))
        {
            if (File.ReadAllText(saveFile) == "True")
            {
                gameObject.SetActive(true);
            }
        }
    }
}
