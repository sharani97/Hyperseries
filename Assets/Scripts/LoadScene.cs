using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class LoadScene : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void LoadPrevScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    public void LoadFirstVideo()
    {
      
        PhotonNetwork.LoadLevel("Video1-Metahuman");
        //PhotonNetwork.LoadLevel("level2");
        //SceneManager.LoadScene("Video1-Metahuman");
    }

    public void LoadSecondVideo()
    {
    
            PhotonNetwork.LoadLevel("Video2-test");

    }

    public void LoadThirdVideo()
    {
            PhotonNetwork.LoadLevel("Video3-skrillex");
     
    }

    public void LoadMainMenu()
    {
        
            PhotonNetwork.LoadLevel("Main Menu");

    }
    
    

}
