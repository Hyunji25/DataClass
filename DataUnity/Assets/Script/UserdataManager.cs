using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using static UnityEditor.ShaderData;
using Unity.VisualScripting;

[System.Serializable]
public class UserForm
{
    public string id;
    public string pw;

    public UserForm(string id, string pw)
    {
        this.id = id;
        this.pw = pw;
    }
}

// 회원가입
// 로그인

public class UserdataManager : MonoBehaviour
{
    string URL = "https://script.google.com/macros/s/AKfycbwCpTNgso3eB_KB8ZjAWl-zq9LLoJmUTLxmNh5w8xbwHXFmnZzmyv298Np31gUx3tTL0w/exec";

    public InputField IDInput, PWInput;
    string id, pw;

    
}