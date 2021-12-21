using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class track : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    public AudioSource audio;
    public Slider audiovolume;
    public VideoPlayer video;
    public Text txt;
    private float videoDuration;
    private float videoTime;
    private float videoFrame;

    Slider tracking;
    bool slide = false;
    // Use this for initialization
    void Start () {
        tracking = GetComponent<Slider> ();
    }

    public void OnPointerDown (PointerEventData a){
        slide = true;
    }

   public void OnPointerUp(PointerEventData a){
    float frame = (float)tracking.value * (float)video.frameCount;
    video.frame = (long)frame;
    slide = false;
    }
                 
   // Update is calLled once per frame
    void Update () {
        videoDuration =(float)video.clip.length;
        videoFrame=(float)video.time;
        //minutes et secondes sur le curseur
        float actualMinutes=Mathf.FloorToInt(videoFrame / 60);
        float actualSeconds=Mathf.FloorToInt(videoFrame % 60);
        //minutes et secondes pour la longueur de la video
        float videoMinutes=Mathf.FloorToInt(videoDuration / 60);
        float videoSeconds=Mathf.FloorToInt(videoDuration % 60);

        txt.text = actualMinutes.ToString("00") + ":" + actualSeconds.ToString("00") + "/" + videoMinutes.ToString("00") + ":" + videoSeconds.ToString("00");
        if (!slide) {
            tracking.value = (float)video.frame / (float)video.frameCount;
        }
    }

    public void volume(){
        audio.volume = audiovolume.value;
    }

    
}