using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class flickering_light : MonoBehaviour
{
    public bool is_flickering = false;
    public float time_delay;

    void Update()
    {
        if (is_flickering == false)
        {
            StartCoroutine(flickering_light());
        }

        IEnumerator flickering_light()
        {
            is_flickering = true;
            this.gameObject.GetComponent<Light>().enabled = false;
            time_delay = Random.Range(0.0f, 0.7f);
            yield return new WaitForSeconds(time_delay);
            this.gameObject.GetComponent<Light>().enabled = true;
            time_delay = Random.Range(0.0f, 0.7f);
            yield return new WaitForSeconds(time_delay);
            is_flickering = false;

        }
        
    }
}
