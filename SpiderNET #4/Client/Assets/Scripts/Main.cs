using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour 
{
	void Start () 
    {
        SendEcho("SpiderNET");
        SendEchoThreeParam("SpiderNET", 12345, 1.23f);
	}

    public void SendEcho(string data)
    {
        Message echo = new Message();
        echo.URL = "localhost:9993/HelloWorld/Echo";
        echo.Data.Add("data", data);
        StartCoroutine(Request(echo));
    }

    public void SendEchoThreeParam(string data1, int data2, float data3)
    {
        Message echoThreeParam = new Message();
        echoThreeParam.URL = "localhost:9993/HelloWorld/EchoThreeParam";
        echoThreeParam.Data.Add("data1", data1);
        echoThreeParam.Data.Add("data2", data2);
        echoThreeParam.Data.Add("data3", data3);
        StartCoroutine(Request(echoThreeParam));
    }

    IEnumerator Request(Message data)
    {
        WWW www = new WWW(string.Format("{0}?{1}", data.URL, data.MakeParam()));
        yield return www;

        // www.error 값이 없다면 성공이다.
        if (string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.text);
        }
        else
        {
            Debug.Log(www.error);
        }

        www.Dispose();
    }
}
