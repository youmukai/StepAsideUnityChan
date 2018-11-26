using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManeger : MonoBehaviour {
    private Transform myTransform;
    private GameObject obj;
    // Use this for initialization
    void Start () {
        obj = GameObject.Find( "Main Camera");
        this.myTransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
		if(myTransform.position.z < obj.transform.position.z)
        {
            Destroy(gameObject);
        }
	}
}
