using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int score = 0;
    public float speed = 5.0f;
    public ParticleSystem particleSystemGood;
    public ParticleSystem particleSystemBad;
    private AudioSource audioSource;
    public AudioClip goodSound;
    public AudioClip badSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal*speed*Time.deltaTime,0,vertical*speed*Time.deltaTime));
        audioSource = GetComponent<AudioSource>();
       
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Good"))
        {
            audioSource.clip = goodSound;
            audioSource.Play();
            particleSystemGood.Play();
            score += 1;
            Debug.Log(score);
            Destroy(other.gameObject);
        }else if(other.gameObject.CompareTag("Bad")){
            audioSource.clip = badSound;
            audioSource.Play();
             particleSystemBad.Play();
            score -= 1;
            Debug.Log(score);
            Destroy(other.gameObject);
        }
    }
}
