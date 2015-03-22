using UnityEngine;
using System.Collections;

public class titleScreen : MonoBehaviour 
{

	public GameObject player;
	public GameObject headphones;
	public GameObject mouse;
	public GameObject titleClickable;
	public GameObject hand;
	public GameObject click;

	public GameObject camMove;
	public GameObject camMove2;

	public bool moveOk = false;
	public bool clickOk = false;
	public bool isBeginning = true;


	void Start () 
	{
	StartCoroutine(headphonesAppear(2.0f));
	StartCoroutine(mouseAppear(4.0f));
	StartCoroutine(handAppear(7.0f));
	}

	void Update () 
	{
/*		if(player.GetComponent<isBegin>().isBeginning)
		{
			camMove.GetComponent<MouseLook>().sensitivityY = 2;
			camMove2.GetComponent<MouseLook>().sensitivityX = 2;
		} */
	}

	IEnumerator headphonesAppear (float headTime) 
		{
			yield return new WaitForSeconds(headTime);
			headphones.SetActive(true);	
		}
	IEnumerator mouseAppear (float mouseTime) 
		{
			yield return new WaitForSeconds(mouseTime);
			mouse.SetActive(true);
			titleClickable.SetActive(true);
			camMove.GetComponent<MouseLook>().enabled = true;
			camMove2.GetComponent<MouseLook>().enabled = true;
			player.GetComponent<isBegin>().isBeginning = true;
			moveOk = true;
		}
	IEnumerator handAppear (float handTime) 
		{
			yield return new WaitForSeconds(handTime);
			hand.SetActive(true);
			clickOk = true;	
		}
}
