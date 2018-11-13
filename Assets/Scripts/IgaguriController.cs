using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IgaguriController : MonoBehaviour {

    GameObject pointText;
    GameObject igaguriDestroy;
    public void Shoot(Vector3 dir){
        GetComponent<Rigidbody>().AddForce(dir); // 重力に力を加える
    }
    void OnCollisionEnter(Collision other){
        GetComponent<Rigidbody>().isKinematic = false; // 衝突した瞬間(OncollisionEnter)イガグリに加わる力を無効にする
        GetComponent<ParticleSystem>().Play(); //衝突した瞬間エフェクトを発動
        if(other.gameObject.tag == "P10"){
            this.pointText.GetComponent<ui>().getPoint();
        }
    }


    // Use this for initialization
    void Start () {
        this.pointText = GameObject.Find("Point");
        //Shoot(new Vector3(0, 200, 2000)); // 重力で落ちないようにyにも200
	}
	
	// Update is called once per frame
	void Update () {

        igaguriDestroy = GameObject.Find("igaguriPrefab(Clone)");
        Vector3 igaPos = transform.position;
        if(igaPos.y < 1f){
            Destroy(igaguriDestroy);
        }

        //Destroy(igaguriDestroy, 1f);


    }
}
