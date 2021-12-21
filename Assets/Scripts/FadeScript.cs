using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;

    [SerializeField] private bool fadeIn = false;
    [SerializeField] private bool fadeOut = false;
    public float timeRemaining = 10;
    bool down;
    bool status;

    public void ShowUI ()
    {
        fadeIn=true;
        fadeOut=false;
    }
    public void HideUI ()
    {
        fadeOut = true;
        timeRemaining = 10;
        fadeIn= false;
    }

    public void ResetTimer()
    {
        timeRemaining = 10;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump")){
            down=true;
            timeRemaining = 10;
            fadeIn=true;
            fadeOut=false;
        }
        if (fadeIn)
        {
            if(myUIGroup.alpha <1)
            {
                myUIGroup.alpha += Time.deltaTime;
                if (myUIGroup.alpha >=1)
                {
                    fadeIn= false ;
                }
            }
            status=true;
        }

        if (fadeOut)
        {
            if(myUIGroup.alpha >=0)
            {
                myUIGroup.alpha -= Time.deltaTime;
                if (myUIGroup.alpha ==0)
                {
                    fadeOut= false ;
                }
            }
            status=false;
        }
        if (timeRemaining>0){
                fadeIn=true;
                fadeOut=false;
                timeRemaining -= Time.deltaTime;
            }
            if (timeRemaining<=0){
                fadeIn=false;
                fadeOut=true;
                down=false;
            }
        Debug.Log(Time.deltaTime);
    }
}