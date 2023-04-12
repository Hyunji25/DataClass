using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using Unity.VisualScripting.FullSerializer;

[System.Serializable]
public class UserData
{
    public string order, result, msg, value;
}

public class UserdataManager : MonoBehaviour
{
    string URL = "https://script.google.com/macros/s/AKfycbwCpTNgso3eB_KB8ZjAWl-zq9LLoJmUTLxmNh5w8xbwHXFmnZzmyv298Np31gUx3tTL0w/exec";
    public UserData UD;
    public InputField IDInput, PWInput;
    string id, pw;

    bool SetIDPW()
    {
        id = IDInput.text.Trim();
        pw = PWInput.text.Trim();

        if (id == "" || pw == "")
            return false;
        else return true;
    }

    public void Register()
    {
        if (!SetIDPW())
        {
            print("아이디 또는 비밀번호가 비어있습니다");
            return;
        }

        WWWForm form = new WWWForm();
        form.AddField("order", "register");
        form.AddField("id", id);
        form.AddField("pw", pw);

        StartCoroutine(Post(form));
    }

    IEnumerator Start()
    {
        /* 
        // [doGet]
        UnityWebRequest www = UnityWebRequest.Get(URL);
        yield return www.SendWebRequest();

        string data = www.downloadHandler.text;
        print(data);
        */

        // [doPost]
        WWWForm form = new WWWForm();
        form.AddField("value", "값");

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();

        string data = www.downloadHandler.text;
        print(data);
    }
}
