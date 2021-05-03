using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffectSound : MonoBehaviour
{
    // Start is called before the first frame update
    public bool play;
     AudioSource sound;

    float update;
    void Start()
    {
        sound = gameObject.GetComponent<AudioSource>();
        update += Time.deltaTime;
    }

    // Update is called once per frame
    void Update() {

        if (play == true)
        {
            update = 0.0f;
            if (update < 2.0f)

            {
                sound.Play();
                Debug.Log("hit effec sound");


            }

            play = false;
        }
    }
}
