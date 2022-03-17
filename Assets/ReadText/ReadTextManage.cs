using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadTextManage : MonoBehaviour
{
    public string filename= "readtext"; 
    public string[] color;

    // Use this for initialization
    void Start()
    {

        Debug.Log("读取文本中的内容使用,间隔分开"); 

        Read();
    }
      
    [Sirenix.OdinInspector.Button]
    void Read()
    {
        color= BSGTextExtension.ReadText(filename);  
    }

    // Update is called once per frame
    void Update()
    {

    }
}
