using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{

    public GameObject igaguriPrefab;
    GameObject unitychan;
    GameObject iga;

    // Use this for initialization
    void Start()
    {
        //unitychan = GameObject.Find("unitychan");
        iga = GameObject.Find("unitychan/Iga");

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 igaPos = iga.transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefab) as GameObject;
            igaguri.transform.position = igaPos;
            //igaguri.GetComponent<IgaguriController>().Shoot(new Vector3(0, 200, 2000));

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction; // directionはカメラからタップした座標に向かうベクトル(originはカメラの視点)
            //Debug.Log(worldDir.normalized);
            igaguri.GetComponent<IgaguriController>().Shoot(worldDir.normalized * 4000);
            //directionベクトルの持つ normalized 変数を使い長さ「１」のベクトルにして　* 2000
            //一旦長さを「１」にすることでベクトルの大きさに関わらず一定の力をイガグリにかけることができる

        }


    }
}
