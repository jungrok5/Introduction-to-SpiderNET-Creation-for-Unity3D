using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Message 
{
    // 성능을 위해서 미리 선언해놓고 사용
    private static readonly string KVP = "{0}={1}&";

    public string URL;
    public Dictionary<string, object> Data;

    public Message()
    {
        Data = new Dictionary<string, object>();
    }

    public string MakeParam()
    {
        // 문자열을 직접 더하지 않고 StringBuilder 사용한다
        StringBuilder sb = new StringBuilder();
        foreach (var item in Data)
        {
            // 키=값&키=값& 형태로 만들어 낸다
            sb.AppendFormat(KVP, item.Key, item.Value);
        }

        // 마지막에 붙은 & 제거
        if (sb.Length != 0)
            sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }
}
