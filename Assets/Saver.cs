using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Save1()
    {
        string saveFile = Application.persistentDataPath + "/level1";
        File.WriteAllText(saveFile, "True");
    }
    public void Save2()
    {
        string saveFile = Application.persistentDataPath + "/level2";
        File.WriteAllText(saveFile, "True");
    }

}
