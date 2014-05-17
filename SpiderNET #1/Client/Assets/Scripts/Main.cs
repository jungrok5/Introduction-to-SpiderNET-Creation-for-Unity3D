﻿using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour 
{
	void Start () 
    {
        StartCoroutine(RequestGoogle());
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
    }
}
