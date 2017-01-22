using System;
using UnityEngine;

public class AuraPlayer : MonoBehaviour {

    public GameObject auraBlue;
    public GameObject auraGreen;
    public GameObject auraYellow;

    public Color color;

    // Use this for initialization
    void Start () {

        //the_renderer.color = new Color(red, green, blue, alpha);
        auraBlue.SetActive(false);
        auraGreen.SetActive(false);
        auraYellow.SetActive(false);
	}


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Blue")
        {

            auraBlue.transform.localScale = new Vector3(1, 1, 1);
            auraBlue.SetActive(true);

        }

         if (other.tag == "Green")
        {

            auraGreen.transform.localScale = new Vector3(1, 1, 1);
            auraGreen.SetActive(true);

        }

         if (other.tag == "Yellow")
        {

            auraYellow.transform.localScale = new Vector3(1, 1, 1);
            auraYellow.SetActive(true);

        }
    }

    void Update()
    {

        if (auraBlue.activeInHierarchy == true && auraBlue.transform.localScale.x > 0)
        {
            auraBlue.transform.localScale += new Vector3(-0.01f, -0.01f, -0.01f);
        }
        else if(auraBlue.activeInHierarchy == true && auraBlue.transform.localScale.x <= 0)
        {
            auraBlue.transform.localScale = new Vector3(1, 1, 1);
            auraBlue.SetActive(false);
        }
        
        if (auraGreen.activeInHierarchy == true && auraGreen.transform.localScale.x > 0)
        {
            auraGreen.transform.localScale += new Vector3(-0.01f, -0.01f, -0.01f);
        }
        else if(auraGreen.activeInHierarchy == true && auraGreen.transform.localScale.x <= 0)
        {
            auraGreen.transform.localScale = new Vector3(1, 1, 1);
            auraGreen.SetActive(false);
        }

        if (auraYellow.activeInHierarchy == true && auraYellow.transform.localScale.x > 0)
        {
            auraYellow.transform.localScale += new Vector3(-0.01f, -0.01f, -0.01f);
        }
        else if(auraYellow.activeInHierarchy == true && auraYellow.transform.localScale.x <= 0)
        {
            auraYellow.transform.localScale = new Vector3(1, 1, 1);
            auraYellow.SetActive(false);
        }


    }
}
