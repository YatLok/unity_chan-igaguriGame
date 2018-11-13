using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour {
    GameObject pointText;
    GameObject target;
    GameObject timeText;
    int point = 0;
    float time = 10f;
    public void getPoint(){
        point += 10;
    }

    // Use this for initialization
    void Start () {
        this.pointText = GameObject.Find("Point");
        this.target = GameObject.Find("target");
        this.timeText = GameObject.Find("Time");
	}
	
	// Update is called once per frame
	void Update () {
        if(this.point >= 100){
            Destroy(target);
        }
        this.time -= Time.deltaTime;
        this.timeText.GetComponent<Text>().text = "countdown : " + this.time.ToString("00");
        if(this.point >=100){
            SceneManager.LoadScene("win");
        }
        else if(this.time <= 0f){
            SceneManager.LoadScene("lose");
            //Time.timeScale = 0;
        }
        //Debug.Log(this.time);

        this.pointText.GetComponent<Text>().text = this.point.ToString() + "point";
        //Debug.Log(point);
    }
}
