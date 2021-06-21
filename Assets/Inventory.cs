using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    // Start is called before the first frame update
    void Start()
    {
        string saveFile = Application.persistentDataPath + "/gamedata";
        if (File.Exists(saveFile))
        {
            string fileContents = File.ReadAllText(saveFile);

            image1.SetActive(fileContents.Split(' ')[0] == "True");
            image2.SetActive(fileContents.Split(' ')[1] == "True");
            image3.SetActive(fileContents.Split(' ')[2] == "True");
            image4.SetActive(fileContents.Split(' ')[3] == "True");
            image5.SetActive(fileContents.Split(' ')[4] == "True");
        }
    }
}
