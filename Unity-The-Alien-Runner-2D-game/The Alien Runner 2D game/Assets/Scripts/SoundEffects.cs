using UnityEngine;
using System.Collections;

public class SoundEffects : MonoBehaviour
{

    public AudioClip jumpSound;

    void FixedUpdate()
	{		
		if (Input.GetKeyDown (KeyCode.Space))		
		{
            audio.clip = jumpSound;
            audio.Play(); 
        }
    }
}
