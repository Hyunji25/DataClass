using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Register : MonoBehaviour
{
    public void OnClickRegisterButton()
    {
        WWWForm form = new WWWForm();
        form.AddField("order", "register");
        form.AddField("id", "test");
        form.AddField("password", "1234567890");

        StartCoroutine(Post(form));
    }

    private IEnumerator Post(WWWForm form)
    {
        string url = "https://script.google.com/macros/s/AKfycbwCpTNgso3eB_KB8ZjAWl-zq9LLoJmUTLxmNh5w8xbwHXFmnZzmyv298Np31gUx3tTL0w/exec";
        using (UnityWebRequest www = UnityWebRequest.Post(url, form))
        {
            yield return www.SendWebRequest();

            if (www.isDone)
                print(www.downloadHandler.text);
            else
                print("Error");
        }
    }
}
