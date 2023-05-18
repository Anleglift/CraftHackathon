using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Web : MonoBehaviour
{
    public GameObject pulaMatii;
    public GameObject pizdaMatii;
    public GameObject rasaMatii;
    void Start()
    {
        //StartCoroutine(GetDate());
        //StartCoroutine(GetUsers());  
        //StartCoroutine(Login("iapa1", "123"));  
    }

    public IEnumerator GetDate()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/UnityProjectHackCraft/GetDate.php"))
        {
            yield return www.Send();

            if(www.isNetworkError || www.isHttpError){
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                byte[] results = www.downloadHandler.data;
            }
        }
    }


    public IEnumerator GetUsers()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/UnityProjectHackCraft/getUsers.php"))
        {
            yield return www.Send();

            if(www.isNetworkError || www.isHttpError){
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                byte[] results = www.downloadHandler.data;
            }
        }
    }

    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UnityProjectHackCraft/Login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                pulaMatii.SetActive(false);
                pizdaMatii.SetActive(true);
                rasaMatii.SetActive(true);
                //Debug.Log(www.downloadHandler.text);
            }
        }
    }
}