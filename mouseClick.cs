using UnityEngine;
using System.Collections;

public class mouseClick : MonoBehaviour 
{
	public int totalCrayons = 0;
	public float thrust;

	public GameObject crosshair;
	public GameObject crosshairHighlight;


	public GameObject paperBlank;
	public GameObject paperBlur;
	public GameObject paperEnd;

	public GameObject camMain;
	public GameObject camEnd;

	public GameObject redCray;
	public GameObject redCrayEat;
	public GameObject blueCray;
	public GameObject blueCrayEat;
	public GameObject purpleCray;
	public GameObject purpleCrayEat;
	public GameObject yellowCray;
	public GameObject yellowCrayEat;
	public GameObject greenCray;
	public GameObject greenCrayEat;
	public GameObject orangeCray;
	public GameObject orangeCrayEat;
	public Rigidbody blackCray;
	public Rigidbody blackCray2;
	public GameObject redCrumbs;
	public GameObject purpleCrumbs;
	public GameObject blueCrumbs;
	public GameObject greenCrumbs;
	public GameObject yellowCrumbs;
	public GameObject orangeCrumbs;
	
	public Animator redEat;
	public Animator blueEat;
	public Animator purpleEat;
	public Animator yellowEat;
	public Animator greenEat;
	public Animator orangeEat;

	public AudioSource paperRustle;
	public AudioSource crayonTap;
	public AudioSource crayonEat;
	public AudioSource crayonEat2;
	public AudioSource swallowOne;
	public AudioSource burpOne;
	public AudioSource gulp;
	public AudioSource breathe;
	public AudioSource burpTwo;
	public AudioSource burpThree;
	public AudioSource gulpThree;
	public AudioSource sniff;

	public ParticleSystem crumbs;
	public GameObject crumbsObj;


	public bool isEating = false;



	
	void Start () 
	{
		blackCray = GameObject.Find("black crayon").GetComponent<Rigidbody>();
		blackCray2 = GameObject.Find("black crayon2").GetComponent<Rigidbody>();
		//paperBlank = GameObject.Find("paper");
		//paperBlur = GameObject.Find("paper end blurry");
		//paperEnd = GameObject. Find("paper end");
	}
	
	
	void Update () 
	{
		int redLayer = 1 << 8;
		int blueLayer = 1 << 9;
		int purpleLayer = 1 << 10;
		int yellowLayer = 1 << 12;
		int greenLayer = 1 << 13;
		int orangeLayer = 1 << 14;
		int blackLayer = 1 << 15;
		int endLayer = 1 << 16;
		int aqumaLayer = 1 << 17;
		int blackLayer2 = 1 << 20;

		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection (Vector3.forward);

		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, redLayer))
		{
			//Debug.Log ("I'm gonna eat the red one!");
			crosshairHighlight.SetActive(true);

			if ((Input.GetButtonDown ("Fire1")) && (isEating == false)) 
			{
				if (totalCrayons == 4)
				{	
					breathe.Play();
				}
				if (totalCrayons == 6)
				{
					gulpThree.Play();
				}
				crumbs.Play();	
				crayonTap.Play();
				isEating = true;
				redCray.SetActive(false);
				redCrayEat.SetActive(true);
				redEat.SetBool("eat it", true);
				crayonEat.Play();
				StartCoroutine(makeCrumbs(3.0f));
				crumbs.startColor = new Color (0.6f, 0, 0, 1);
				StartCoroutine (redOff(7.1f));
				StartCoroutine(noCrumbs(7.0f));
				StartCoroutine(makeRed(5.0f));

			}
		}
		else
		{
			crosshairHighlight.SetActive(false);
		}
		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, blueLayer))
		{
			crosshairHighlight.SetActive(true);
			if ((Input.GetButtonDown ("Fire1")) && (isEating == false))
			{
				if (totalCrayons == 4)
				{	
					breathe.Play();
				}
				if (totalCrayons == 6)
				{
					gulpThree.Play();
				}

				crayonTap.Play();
				isEating = true;
				blueCray.SetActive(false);
				blueCrayEat.SetActive(true);
				blueEat.SetBool("eat it", true);
				crayonEat2.Play();
				StartCoroutine(makeCrumbs(3.0f));
				crumbs.startColor = new Color (0, 0, 1, 1);
				StartCoroutine(noCrumbs(7.0f));
				StartCoroutine (blueOff(7.1f));
				StartCoroutine(makeBlue(5.0f));
			}
		}

		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, purpleLayer))
		{
			crosshairHighlight.SetActive(true);
			if ((Input.GetButtonDown ("Fire1")) && (isEating == false))
			{
				if (totalCrayons == 4)
				{	
					breathe.Play();
				}
				if (totalCrayons == 6)
				{
					gulpThree.Play();
				}

				crayonTap.Play();
				isEating = true;
				purpleCray.SetActive(false);
				purpleCrayEat.SetActive(true);
				purpleEat.SetBool("eat it", true);
				crayonEat.Play();
				StartCoroutine(makeCrumbs(3.0f));
				crumbs.startColor = new Color (0.47f, 0, 0.77f, 1);
				StartCoroutine(noCrumbs(7.0f));
				StartCoroutine (purpleOff(7.1f));
				StartCoroutine(makePurp(5.0f));
			}
		}
		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, yellowLayer))
		{
			crosshairHighlight.SetActive(true);
			if ((Input.GetButtonDown ("Fire1")) && (isEating == false))
			{
				if (totalCrayons == 4)
				{	
					breathe.Play();
				}
				if (totalCrayons == 6)
				{
					gulpThree.Play();
				}
				crayonTap.Play();
				isEating = true;
				yellowCray.SetActive(false);
				yellowCrayEat.SetActive(true);
				yellowEat.SetBool("eat it", true);
				crayonEat2.Play();
				StartCoroutine(makeCrumbs(3.0f));
				crumbs.startColor = new Color (1, 0.92f, 0.016f, 1);
				StartCoroutine(noCrumbs(7.0f));
				StartCoroutine (yellowOff(7.1f));
				StartCoroutine(makeYellow(5.0f));

			}
		}
		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, greenLayer))
		{
			crosshairHighlight.SetActive(true);
			if ((Input.GetButtonDown ("Fire1")) && (isEating == false))
			{
				if (totalCrayons == 4)
				{	
					breathe.Play();
				}
				if (totalCrayons == 6)
				{
					gulpThree.Play();
				}
				crayonTap.Play();
				isEating = true;
				greenCray.SetActive(false);
				greenCrayEat.SetActive(true);
				greenEat.SetBool("eat it", true);
				crayonEat.Play();
				StartCoroutine(makeCrumbs(3.0f));
				crumbs.startColor = new Color (0, 0.5f, 0, 1);
				StartCoroutine(noCrumbs(7.0f));
				StartCoroutine (greenOff(7.1f));
				StartCoroutine(makeGreen(5.0f));
			}
		}

		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, orangeLayer))
		{
			crosshairHighlight.SetActive(true);
			if ((Input.GetButtonDown ("Fire1")) && (isEating == false))
			{
				crayonTap.Play();
				isEating = true;
				orangeCray.SetActive(false);
				orangeCrayEat.SetActive(true);
				orangeEat.SetBool("eat it", true);
				crayonEat.Play();
				StartCoroutine(makeCrumbs(3.0f));
				crumbs.startColor = new Color (0.85f, 0.69f, 0, 1);
				StartCoroutine(noCrumbs(7.0f));
				StartCoroutine (orangeOff(7.1f));
				StartCoroutine(makeOrange(5.0f));
			}
		}
		
		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, blackLayer))
		{
			crosshairHighlight.SetActive(true);
		}
		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, blackLayer2))
		{
			crosshairHighlight.SetActive(true);
		}

		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, endLayer))
		{
			crosshairHighlight.SetActive(true);
			if ((Input.GetButtonDown ("Fire1")) && (isEating == false))
			{
				paperRustle.Play();
				camEnd.SetActive(true);
				camMain.SetActive(false);
			}
		}
		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, aqumaLayer))
		{
			crosshairHighlight.SetActive(true);
			if ((Input.GetButtonDown ("Fire1")) && (isEating == false))
			{
				paperRustle.Play();
				camEnd.SetActive(true);
				camMain.SetActive(false);
			}
		}





		if(isEating)
		{
			crosshair.SetActive(false);
			crosshairHighlight.SetActive(false);
			StartCoroutine(headBobber(3.0f));
			StartCoroutine(bobStop(6.5f));

		}
		if(isEating == false)
		{
			crosshair.SetActive(true);
		
			//GameObject.Find("Main Camera").GetComponent<HeadBob>().bobAmount = 0.0f;
		}


		//SFX playback control
		if (totalCrayons == 1)
		{
			swallowOne.Play();
			totalCrayons += 1;
		}
		if(totalCrayons == 2)
		{
			GameObject.Find("State Check").GetComponent<isBegin>().slowState = 1;
		}
		if (totalCrayons == 3)
		{
			burpOne.Play();
			totalCrayons += 1;
		}
		if(totalCrayons == 4)
		{
			GameObject.Find("State Check").GetComponent<isBegin>().slowState = 2;
		}
		if (totalCrayons == 5)
		{
			sniff.Play();	
			totalCrayons += 1;
		}
		if(totalCrayons == 6)
		{
			GameObject.Find("State Check").GetComponent<isBegin>().slowState = 3;
		}
		if (totalCrayons == 7)
		{
			burpTwo.Play();
			totalCrayons += 1;
		}
		if(totalCrayons == 8)
		{
			GameObject.Find("State Check").GetComponent<isBegin>().slowState = 4;
		}
		if(totalCrayons == 10)
		{
			GameObject.Find("State Check").GetComponent<isBegin>().slowState = 5;
		}



		if(totalCrayons >= 6)
		{
			burpThree.Play();
			paperBlank.SetActive(false);
			paperBlur.SetActive(true);
		}

	}

	void FixedUpdate ()
	{
		int blackLayer = 1 << 15;
		int blackLayer2 = 1 << 20;

		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection (Vector3.forward);

		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, blackLayer))
		{
			//crosshairHighlight.SetActive(true);
			//Debug.Log ("you're looking at the black crayon");
			if ((Input.GetButtonDown ("Fire1")) && (isEating == false))
			{
				crayonTap.Play();
				blackCray.AddForce (transform.forward * thrust);
			}
		}
		if(Physics.Raycast (transform.position, fwd, out hit, Mathf.Infinity, blackLayer2))
		{
			//crosshairHighlight.SetActive(true);
			//Debug.Log ("you're looking at the black crayon");
			if ((Input.GetButtonDown ("Fire1")) && (isEating == false))
			{
				crayonTap.Play();
				blackCray2.AddForce (transform.forward * thrust);
			}
		}
	}


	IEnumerator redOff (float redTime) 
		{
			yield return new WaitForSeconds(redTime);
			redEat.SetBool("eat it", false);
			redCrayEat.SetActive(false);
			totalCrayons += 1;
			isEating = false;
		}
	IEnumerator blueOff (float blueTime) 
		{
			yield return new WaitForSeconds(blueTime);
			blueEat.SetBool("eat it", false);
			blueCrayEat.SetActive(false);
			totalCrayons += 1;
			isEating = false;
		}
	IEnumerator purpleOff (float purpleTime) 
		{
			yield return new WaitForSeconds(purpleTime);
			purpleEat.SetBool("eat it", false);
			purpleCrayEat.SetActive(false);
			totalCrayons += 1;
			isEating = false;
		}
	IEnumerator yellowOff (float yellowTime) 
		{
			yield return new WaitForSeconds(yellowTime);
			yellowEat.SetBool("eat it", false);
			yellowCrayEat.SetActive(false);
			totalCrayons += 1;
			isEating = false;
		}
	IEnumerator greenOff (float greenTime) 
		{
			yield return new WaitForSeconds(greenTime);
			greenEat.SetBool("eat it", false);
			greenCrayEat.SetActive(false);
			totalCrayons += 1;
			isEating = false;
		}
	IEnumerator orangeOff (float orangeTime) 
		{
			yield return new WaitForSeconds(orangeTime);
			orangeEat.SetBool("eat it", false);
			orangeCrayEat.SetActive(false);
			totalCrayons += 1;
			isEating = false;
		}
	IEnumerator headBobber (float bobTime) 
		{
			yield return new WaitForSeconds(bobTime);
			GameObject.Find("Main Camera").GetComponent<HeadBob>().bobAmount = 1.0f;
		}
	IEnumerator bobStop (float bobnoTime) 
		{
			yield return new WaitForSeconds(bobnoTime);
			GameObject.Find("Main Camera").GetComponent<HeadBob>().bobAmount = 0.0f;
		}
	IEnumerator makeCrumbs (float crumbTime) 
		{
			yield return new WaitForSeconds(crumbTime);
			crumbsObj.SetActive(true);
			crumbs.Play();
		}
	IEnumerator noCrumbs (float nocrumbTime) 
		{
			yield return new WaitForSeconds(nocrumbTime);
			//crumbs.Pause();
			crumbsObj.SetActive(false);
		//	crumbs.Stop();
		}
	IEnumerator makeRed (float redTime) 
		{
			yield return new WaitForSeconds(redTime);
			redCrumbs.SetActive(true);
		}
	IEnumerator makePurp (float purpTime) 
		{
			yield return new WaitForSeconds(purpTime);
			purpleCrumbs.SetActive(true);
		}
	IEnumerator makeBlue (float blueTime) 
		{
			yield return new WaitForSeconds(blueTime);
			blueCrumbs.SetActive(true);
		}
	IEnumerator makeGreen (float greenTime) 
		{
			yield return new WaitForSeconds(greenTime);
			greenCrumbs.SetActive(true);
		}
	IEnumerator makeYellow (float yellowTime) 
		{
			yield return new WaitForSeconds(yellowTime);
			yellowCrumbs.SetActive(true);
		}
	IEnumerator makeOrange (float orangeTime) 
		{
			yield return new WaitForSeconds(orangeTime);
			orangeCrumbs.SetActive(true);
		}

}
