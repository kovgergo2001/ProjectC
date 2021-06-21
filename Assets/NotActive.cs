using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotActive : MonoBehaviour
{
    public GameObject gameObject;
    void Start()
    {
        string saveFile = Application.persistentDataPath + "/level1";
        if (File.Exists(saveFile))
        {
            if (File.ReadAllText(saveFile) == "True")
            {
                gameObject.SetActive(false);
            }
        }
    }
}
