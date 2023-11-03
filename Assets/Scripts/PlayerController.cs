using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int score = 0;
    public float speed = 5.0f;
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
       
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Good"))
        {
            score += 1;
            Debug.Log(score);
            Destroy(other.gameObject);
        }else if(other.gameObject.CompareTag("Bad")){
            score -= 1;
            Debug.Log(score);
            Destroy(other.gameObject);
        }
    }
}
