using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Banana : MonoBehaviour
{
    private int banana = 0;

    [SerializeField] private Text bananaText;

    [SerializeField] private AudioSource collectionSoundEffect;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Banana"))
        {
            collectionSoundEffect.Play();

            Destroy(collision.gameObject);
            banana++;

            Debug.Log("Banana: " + banana);

            bananaText.text = "Banana : " + banana;
        }
    }
}
