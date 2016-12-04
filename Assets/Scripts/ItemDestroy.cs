using UnityEngine;
using System.Collections;

public class ItemDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
//        Debug.Log("アイテム削除");
    }

}
