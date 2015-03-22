using UnityEngine;
using System.Collections;

public class particleCode : MonoBehaviour {

     void Start ()
     {
             //Change Foreground to the layer you want it to display on 
             //You could prob. make a public variable for this
             particleSystem.renderer.sortingLayerName = "Foreground";
             particleSystem.renderer.sortingOrder = 10;
     }
	
	// Update is called once per frame
	void Update () {
	
	}
}
