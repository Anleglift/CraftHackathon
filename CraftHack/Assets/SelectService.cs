using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectService : MonoBehaviour
{
    public GameObject HackathonB;
    public GameObject TeamB;
    public GameObject HelpB;
    public GameObject ArticlesB;
    public GameObject Control;
    public CanvasGroup canvasGroup;
    public float lerpDuration = 1f;
    private float currentLerpTime;
    public bool CanChange = true;
    private bool isLerping = false;
    private bool StartLerp = false;
    private bool StopLerp = false;
    public GameObject Backgrounds1;
    public void Start()
    {
        canvasGroup.alpha = 0f;
        HackathonB.SetActive(true);
        TeamB.SetActive(false);
        HelpB.SetActive(false);
        ArticlesB.SetActive(false);
        Control.SetActive(true);
    }

    public void Update()
    {
        if (StartLerp)
        {
            isLerping = true;
            currentLerpTime += Time.deltaTime;

            // Calculate the lerp progress
            float t = currentLerpTime / lerpDuration;
            t = Mathf.Clamp01(t);

            // Lerp the alpha value
            float alpha = Mathf.Lerp(0f, 1f, t);
            canvasGroup.alpha = alpha;

            // Check if the lerp is completed
            if (t >= 1f)
            {
                isLerping = false;
                StartLerp = false;
            }
        }
        else if (StopLerp)
        {
            isLerping = true;
            currentLerpTime += Time.deltaTime;

            // Calculate the lerp progress
            float t = currentLerpTime / lerpDuration;
            t = Mathf.Clamp01(t);

            // Lerp the alpha value
            float alpha = Mathf.Lerp(1f, 0f, t);
            canvasGroup.alpha = alpha;

            // Check if the lerp is completed
            if (t >= 1f)
            {
                Control.SetActive(false);
                isLerping = false;
                StopLerp = false;
                CanChange = true;
            }
        }
    }

    public void Hackathons()
    {
        if (!HackathonB.activeSelf && CanChange)
        {
            Backgrounds1.transform.position = new Vector3(0f, 0f, 0f);

            Control.SetActive(true);
            StartLerp = true;
            currentLerpTime = 0f;
            CanChange = false;

            Invoke("ShowHack", 2f);
            Invoke("Deactivate", 5f);

        }
    }

    public void Teams()
    {
        if (!TeamB.activeSelf && CanChange)
        {
            Backgrounds1.transform.position = new Vector3(0f, 0f, 0f);

            StartLerp = true;
            currentLerpTime = 0f;
            CanChange = false;
            Control.SetActive(true);

            Invoke("ShowHack1", 2f);
            Invoke("Deactivate", 5f);

        }
    }

    public void Help()
    {
        if (!HelpB.activeSelf && CanChange)
        {
            Backgrounds1.transform.position = new Vector3(0f, 0f, 0f);


            StartLerp = true;
            currentLerpTime = 0f;
            CanChange = false;
            Control.SetActive(true);

            Invoke("ShowHack2", 2f);
            Invoke("Deactivate", 5f);

        }
    }

    public void Articles()
    {
        if (!ArticlesB.activeSelf && CanChange)
        {
            Backgrounds1.transform.position = new Vector3(0f, 0f, 0f);

            StartLerp = true;
            currentLerpTime = 0f;
            Control.SetActive(true);
            CanChange = false;

            Invoke("ShowHack3", 2f);
            Invoke("Deactivate", 5f);

        }
    }
    public void ShowHack()
    {
        HackathonB.SetActive(true);
        TeamB.SetActive(false);
        HelpB.SetActive(false);
        ArticlesB.SetActive(false);
    }
    public void ShowHack1()
    {
        HackathonB.SetActive(false);
        TeamB.SetActive(true);
        HelpB.SetActive(false);
        ArticlesB.SetActive(false);
    }
    public void ShowHack2()
    {
        HackathonB.SetActive(false);
        TeamB.SetActive(false);
        HelpB.SetActive(true);
        ArticlesB.SetActive(false);
    }
    public void ShowHack3()
    {

        HackathonB.SetActive(false);
        TeamB.SetActive(false);
        HelpB.SetActive(false);
        ArticlesB.SetActive(true);
    }
    public void Deactivate()
    {
        StopLerp = true;
        currentLerpTime = 0f;
    }
}