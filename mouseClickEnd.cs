using UnityEngine;
using System.Collections;

public class mouseClickEnd : MonoBehaviour 
{
	public GameObject paper;
	public GameObject paperBlur;
	public GameObject paperEnd;

	public GameObject title;
	public GameObject quit;

	public GameObject crosshairHighlight;

	public bool endOn = true;
	public AudioSource burpFive;

	void Start () 
	{
		paper.SetActive(false);
		paperBlur.SetActive(false);
		paperEnd.SetActive(true);
		GameObject.Find("State Check").GetComponent<isBegin>().isBeginning = true; //changes variable for slower cam on seperate obj to true

		StartCoroutine(buttonAppear(1.5f));
	}
	

	void Update () 
	{
		int quitLayer = 1 << 18;
		int titleLayer = 1 << 19;

		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection (Vector3.forward);

		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, quitLayer))
		{
			crosshairHighlight.SetActive(true);
			if (Input.GetButtonDown ("Fire1"))
			{
				burpFive.Play();
				StartCoroutine(quitSoon(0.5f));
			}
		}
		else
		{
			crosshairHighlight.SetActive(false);
		}
		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, titleLayer))
		{
			crosshairHighlight.SetActive(true);
			if (Input.GetButtonDown ("Fire1"))
			{
				burpFive.Play();
				StartCoroutine(titleScreen(0.5f));
			}
		}

	}

	IEnumerator buttonAppear (float buttonTime) 
		{
			yield return new WaitForSeconds(buttonTime);
			title.SetActive(true);
			quit.SetActive(true);
		}
	IEnumerator quitSoon (float quitTime) 
		{
			yield return new WaitForSeconds(quitTime);
			Application.Quit();
		}
	IEnumerator titleScreen (float titleTime) 
		{
			yield return new WaitForSeconds(titleTime);
			Application.LoadLevel(0);
		}


}
