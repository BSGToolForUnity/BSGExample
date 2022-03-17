using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//使用场景 策划写数据在txt中 读取到 面板上 
//editor 适用 

public class BSGTextExtension : MonoBehaviour
{

    /// <summary>
    /// 读取数据 数据用,分割 返回一个数组 
    /// </summary>
    /// <param filename="filename">文件名</param>  
    /// <returns></returns>
    public static string[] ReadText(string filename)
    {
        // 将name 中的内容加载进txt文本中
        TextAsset txt = Resources.Load(filename) as TextAsset;

        string temp = txt.text.Replace(" ", "");  

        string[] strs = temp.Split(',');

        return strs;

        // 以换行符作为分割点，将该文本分割成若干行字符串，并以数组的形式来保存每行字符串的内容
        //string[] str = txt.text.Split('\n'); 

        //// 将该文本中的字符串输出
        //Debug.Log("str[0]= " + str[0]);
        //Debug.Log("str[1]= " + str[1]); 

        // 将每行字符串的内容以逗号作为分割点，并将每个逗号分隔的字符串内容遍历输出
        //foreach (string strs in str)
        //{
        //string[] ss = strs.Split(',');

        //}


    }
}
