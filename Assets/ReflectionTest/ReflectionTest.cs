using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionTest : MonoBehaviour
{

    public int count_ear; 
    public int count_face;
    public int count_eyebrow;
    public int count_eye;
    public int count_nose;
    public int count_mouth;
    public int count_hair;
    [Header("---Body")]
    public int count_body;
    public int count_clothes;
    public int count_pants1;
    [Header("---Arm")]
    public int count_arm;
    public int count_sleeve;
    public int count_leg;
    public int count_pants2;
    public int count_shoes;

    // Use this for initialization 
    void Start()
    {
      
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ReflectionTest rt = transform.GetComponent<ReflectionTest>();

            var txt = BSGTextExtension.ReadText("count");
            for (int i = 0; i < txt.Length; i++)
            {
                string str = txt[i].Substring(0, txt[i].IndexOf(":")).Trim(); 
                var index = txt[i].IndexOf(":") + 1;
                var num = int.Parse(txt[i].Substring(index));


                Debug.Log(num);
                Debug.Log(str);

                rt.GetType().GetField(str).GetValue(rt);
                rt.GetType().GetField(str).SetValue(rt, num); 
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //2有问题 未解决 
            ReflectionTest rt = transform.GetComponent<ReflectionTest>();

            var txt = BSGTextExtension.ReadText("count");
            for (int i = 0; i < txt.Length; i++)
            {
                string str = txt[i].Substring(0, txt[i].IndexOf(":"));
                var index = txt[i].IndexOf(":") + 1;
                var num = int.Parse(txt[i].Substring(index));


                Debug.Log(num);
                Debug.Log(str);

                rt.GetType().GetProperty(str).GetValue(rt, null);
                rt.GetType().GetProperty(str).SetValue(rt, num,null);

  
            }
        }
    }
}
