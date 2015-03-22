using UnityEngine;
using System.Collections;

public class menuMouse : MonoBehaviour 
{

	public GameObject crosshair;
	public GameObject crosshairHighlight;

	public AudioSource continueChime;
	public AudioSource tap;

	public Animator mouseAnim;

	//private bool thumpPlayed = false;

	void Start () 
	{
	
	}
	

	void Update () 
	{

	int mouseLayer = 1 << 11;

	RaycastHit hit;
	Vector3 fwd = transform.TransformDirection (Vector3.forward);


	
	if(GameObject.Find("Control").GetComponent<titleScreen>().moveOk)
		{
			crosshair.SetActive(true);
		}

	if(GameObject.Find("Control").GetComponent<titleScreen>().clickOk)
		{
		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, mouseLayer))
			{
			crosshairHighlight.SetActive(true);
			
			if (Input.GetButtonDown ("Fire1"))
				{
					tap.Play();
					mouseAnim.SetBool("click", true);
					//Debug.Log ("you clicked it!");
				}
			if (Input.GetButtonUp ("Fire1"))
				{
					mouseAnim.SetBool("click", false);
					StartCoroutine(waitLevel(1.5f));
					//audio.PlayOneShot(continueChime, 1.0F);
					continueChime.Play();
				}
			}
		else
			{
			crosshairHighlight.SetActive(false);
			mouseAnim.SetBool("click", false);

			}

		}

	}

	IEnumerator waitLevel (float levelTime) 
		{
			yield return new WaitForSeconds(levelTime);
			Application.LoadLevel(1);
			
		}

}
