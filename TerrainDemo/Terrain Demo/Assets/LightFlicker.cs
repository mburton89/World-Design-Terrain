using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    private Light _light;
    private float _secondsOn;
    private float _secondsOff;

    private void Awake()
    {
        _light = GetComponent<Light>();
    }

    private void Start()
    {
        StartCoroutine(Flicker());
    }

    private IEnumerator Flicker()
    {
        _secondsOff = Random.Range(0.05f, 0.4f);
        _secondsOn = Random.Range(0.025f, 0.2f);

        _light.enabled = true;
        yield return new WaitForSeconds(_secondsOn);

        _light.enabled = false;
        yield return new WaitForSeconds(_secondsOff);

        StartCoroutine(Flicker());
    }
}
