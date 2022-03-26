using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //managing audio
    public AudioSource audioSource;
    public AudioClip[] clip;
    public float volume = 0.5f;

    //  particle system

    // room environment
    float timer = 0.0f;
    public float timeDelay;
    public GameObject roomObject;
    public bool roomActive = false;
    public bool noiseActive = false;
    public GameObject noiseObj;

    public bool particleEnable = false;

    [SerializeField] ParticleSystem envrmntParticle = null;


    // Start is called before the first frame update
    void Start()
    {
        //audioSource.PlayOneShot(clip[0], volume);

       // audioSource.PlayOneShot(clip[1], volume);

        audioSource = GetComponent<AudioSource>();

        //roomObject.SetActive(true);
        //initRoom();

    }

    public void startScene()
    {
        envrmntParticle.Play();
        noiseObj.SetActive(true);


      //background sound 
      //
      audioSource.PlayOneShot(clip[0], volume);



    }


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDelay && roomActive == false)
        {
            roomObject.SetActive(true);
            noiseObj.SetActive(false);

            roomActive = true;
        }
    }
}
