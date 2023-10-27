using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        StartCoroutine(nameof(SoundPlay));
        gameObject.SetActive(false);
    }

    IEnumerator SoundPlay()
    {
        gameObject.GetComponent<AudioSource>().Play();


        yield return null;
    }
}
