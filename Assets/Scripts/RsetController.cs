using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RsetController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PushResetButton() {
        SceneManager.LoadScene("GameScene");
    }
}
