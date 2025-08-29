using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWorks : MonoBehaviour
{
    [SerializeField] private ParticleSystem fireworks1;
    [SerializeField] private ParticleSystem fireworks2;
    [SerializeField] private ParticleSystem fireworks3;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(StopFireworks(fireworks1));
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            StartCoroutine(StopFireworks(fireworks2));
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            StartCoroutine(StopFireworks(fireworks3));
        }
    }
    IEnumerator StopFireworks(ParticleSystem ps)
    {
        ps.Play();
        yield return new WaitForSeconds(2f);
        ps.Stop();
        yield return new WaitForSeconds(2f);
        ps.Play();
    }

}
