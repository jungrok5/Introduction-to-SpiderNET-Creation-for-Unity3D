using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour 
{
	void Start () 
    {
        StartCoroutine(Echo("SpiderNET"));
	}

    IEnumerator Echo(string data)
    {
        WWW www = new WWW(string.Format("localhost:9993/HelloWorld/Echo?data={0}", data));
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

    IEnumerator HelloWorld()
    {
        WWW www = new WWW("localhost:9993/HelloWorld/Index");
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

    IEnumerator RequestGoogle()
    {
        WWW www = new WWW("http://www.google.com");
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
