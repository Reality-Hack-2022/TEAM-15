using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideoOnGrab : MonoBehaviour
{
    public GameObject videoObject;
    public GameObject screenObject;
    public GameObject audioSiren;
    bool videoActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (videoActive == true && videoObject.transform.localScale.x < 2.0f)
        {
            Vector3 scaleChange = new Vector3(0.05f * Time.deltaTime, 0.05f * Time.deltaTime, 0.0f * Time.deltaTime);
            videoObject.transform.localScale += scaleChange;
        }

      /*  if (videoActive == true && videoObject.transform.position.y < 1.0f)
        {
            Vector3 positionChange = new Vector3(0.0f * Time.deltaTime, 0.025f * Time.deltaTime, 0.0f * Time.deltaTime);
            videoObject.transform.position += positionChange;
        }*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Book" && videoActive == false)
        {
            videoObject.SetActive(true);
            audioSiren.SetActive(false);
            if (videoActive == false)
            {
                videoObject.transform.position += new Vector3(0.5f, 0.0f, 0.0f);
            }
            videoActive = true;
        }
    }

    public void PlayVideo()
    {
        videoObject.SetActive(true);
        
        
    }
}
