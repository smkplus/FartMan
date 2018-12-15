using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fart : MonoBehaviour {
    public List<AudioClip> fartSoundList;

    private void Start()
    {
        GetComponent<AudioSource>().clip = fartSoundList[Random.Range(0,fartSoundList.Count)];
        GetComponent<AudioSource>().Play();
    }
}
