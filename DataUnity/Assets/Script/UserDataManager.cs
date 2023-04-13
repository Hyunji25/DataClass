using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine.SceneManagement;

public class UserData
{
    public string order, result;
}

public class UserDataManager : MonoBehaviour
{
    string url = "https://script.google.com/macros/s/AKfycbwCpTNgso3eB_KB8ZjAWl-zq9LLoJmUTLxmNh5w8xbwHXFmnZzmyv298Np31gUx3tTL0w/exec";
    public UserData UD;
    public InputField IDInput, PassInput;
    string id, pw;

    bool SetIDPass()
    {
        id = IDInput.text.Trim();
        pw = PassInput.text.Trim();

        if (id == "" || pw == "") return false;
        else return true;
    }

    public void Register()
    {
        if (!SetIDPass())
        {
            print("아이디 또는 비밀번호가 비어있습니다");
            return;
        }

        WWWForm form = new WWWForm();
        form.AddField("order", "register");
        form.AddField("id", id);
        form.AddField("password", pw);

        StartCoroutine(Post(form));
    }

    public void Login()
    {
        if (!SetIDPass())
        {
            print("아이디 또는 비밀번호가 비어있습니다");
            return;
        }

        WWWForm form = new WWWForm();
        form.AddField("order", "login");
        form.AddField("id", id);
        form.AddField("password", pw);

        StartCoroutine(Post(form));
    }

    private IEnumerator Post(WWWForm form)
    {
        using (UnityWebRequest www = UnityWebRequest.Post(url, form))
        {
            yield return www.SendWebRequest();
            
            if (www.isDone)
                print(www.downloadHandler.text);
            else
                print("Error");
            www.Dispose();
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene("progressScene");
    }
}