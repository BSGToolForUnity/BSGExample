    public int count_ear; 
    public int count_face;
	属性赋值
	文本,间隔
	count_ear:1,count_face:1

	   string str = txt[i].Substring(0, txt[i].IndexOf(":")).Trim(); 
       var index = txt[i].IndexOf(":") + 1;
       var num = int.Parse(txt[i].Substring(index));  

	//根据属性明赋值
    rt.GetType().GetField(str).SetValue(rt, num); 