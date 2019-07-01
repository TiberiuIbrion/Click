using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App_Spawner_Script : MonoBehaviour
{
    public GameObject alarmAppPrefab;       //1
    public GameObject calculatorAppPrefab;  //2
    public GameObject calendarAppPrefab;    //3
    public GameObject chromeAppPrefab;      //4
    public GameObject driveAppPrefab;       //5
    public GameObject facebookAppPrefab;    //6
    public GameObject instagramAppPrefab;   //7
    public GameObject lanternAppPrefab;     //8
    public GameObject magazinAppPrefab;     //9
    public GameObject mapsAppPrefab;        //10
    public GameObject messengerAppPrefab;   //11
    public GameObject musicAppPrefab;       //12
    public GameObject notesAppPrefab;       //13
    public GameObject settingsAppPrefab;    //14
    public GameObject translateAppPrefab;   //15
    public GameObject weatherAppPrefab;     //16
    public GameObject whatsappAppPrefab;    //17
    public GameObject youtubeAppPrefab;     //18
    public int OK;
    GameObject gj;

    public float respawnTime = 10.0f;
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(App_Wave());
    }
    void Awake()
    {
        OK = Random.Range(1, 18);
    }
    private void Spawn_App()
    {
        if (OK == 1)
            gj = Instantiate(alarmAppPrefab) as GameObject;
        if (OK == 2)
            gj = Instantiate(calculatorAppPrefab) as GameObject;
        if (OK == 3)
            gj = Instantiate(calendarAppPrefab) as GameObject;
        if (OK == 4)
            gj = Instantiate(chromeAppPrefab) as GameObject;
        if (OK == 5)
            gj = Instantiate(driveAppPrefab) as GameObject;
        if (OK == 6)
            gj = Instantiate(facebookAppPrefab) as GameObject;
        if (OK == 7)
            gj = Instantiate(instagramAppPrefab) as GameObject;
        if (OK == 8)
            gj = Instantiate(lanternAppPrefab) as GameObject;
        if (OK == 9)
            gj = Instantiate(magazinAppPrefab) as GameObject;
        if (OK == 10)
            gj = Instantiate(mapsAppPrefab) as GameObject;
        if (OK == 11)
            gj = Instantiate(messengerAppPrefab) as GameObject;
        if (OK == 12)
            gj = Instantiate(musicAppPrefab) as GameObject;
        if (OK == 13)
            gj = Instantiate(notesAppPrefab) as GameObject;
        if (OK == 14)
            gj = Instantiate(settingsAppPrefab) as GameObject;
        if (OK == 15)
            gj = Instantiate(translateAppPrefab) as GameObject;
        if (OK == 16)
            gj = Instantiate(weatherAppPrefab) as GameObject;
        if (OK == 17)
            gj = Instantiate(whatsappAppPrefab) as GameObject;
        if (OK == 18)
            gj = Instantiate(youtubeAppPrefab) as GameObject;
        gj.transform.position = new Vector2(Random.Range(-screenBounds.x+1, screenBounds.x-1), screenBounds.y * 2);
    }

    IEnumerator App_Wave()
    {   while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            Spawn_App();
            Awake();
            respawnTime = respawnTime - 0.005f;
        }
    }
}
