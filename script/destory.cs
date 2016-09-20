using UnityEngine;
using System.Collections;

public class destory : MonoBehaviour {

    public GameObject victim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "victim")
        {
            Destroy(other.gameObject);
        }
    }
}

