using UnityEngine;
using System.Collections;

public class menuMouse : MonoBehaviour 
{

	public GameObject crosshair;
	public GameObject crosshairHighlight; //let's player know they can click on something

	public AudioSource continueChime;
	public AudioSource tap;

	public Animator mouseAnim; //animates mouse icon

	//private bool thumpPlayed = false;

	void Start () 
	{
	
	}
	

	void Update () 
	{

	int mouseLayer = 1 << 11; //layer for raycast to read

	RaycastHit hit;
	Vector3 fwd = transform.TransformDirection (Vector3.forward); 
	//allows mouse icon to be click on from first person camera


	
	if(GameObject.Find("Control").GetComponent<titleScreen>().moveOk)
		{
			crosshair.SetActive(true); 
			//check Control > titleScreen to see if it's OK to move the mouse. Make crosshair show up.
		}

	if(GameObject.Find("Control").GetComponent<titleScreen>().clickOk)
		{
		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, mouseLayer))
			{
			crosshairHighlight.SetActive(true);
			//if player puts crosshair over something they can click on, show the highlighted crosshair
			
			if (Input.GetButtonDown ("Fire1"))
				{
					tap.Play();
					mouseAnim.SetBool("click", true);
					//Debug.Log ("you clicked it!");
					//if the player click down on the mouse icon, play the tap sound, turn on the animation for the icon.
				}
			if (Input.GetButtonUp ("Fire1"))
				{
					mouseAnim.SetBool("click", false);
					StartCoroutine(waitLevel(1.5f));
					//audio.PlayOneShot(continueChime, 1.0F);
					continueChime.Play();
					//if player releases mouse button on mouse icon, stop animating the icon, wait 1.5 seconds to load level, play the continue sound.
				}
			}
		else
			{
			crosshairHighlight.SetActive(false);
			mouseAnim.SetBool("click", false);
			//If the player hovers over the mouse icon and then leaves, turn off the highlight crosshair, stop animating. 
			//Then if they release the mouse click while not hovering over the mouse icon, the level won't load.

			}

		}

	}

	IEnumerator waitLevel (float levelTime) 
		{
			yield return new WaitForSeconds(levelTime);
			Application.LoadLevel(1);
			
		}
	//Simple coroutine to wait a second and a half before loading the new page. This way the transistion is not abrupt and can finish the animation/sound.

}
