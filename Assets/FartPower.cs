using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FartPower : Singleton<FartPower> {
    public Image FartSlider;

    private void Start()
    {
        StartCoroutine(Filling());
    }

    public void Fart () {
        FartSlider.fillAmount -= 0.25f;
    }

    IEnumerator Filling()
    {
        yield return new WaitForSeconds(1);
        FartSlider.fillAmount += 0.25f;
        StartCoroutine(Filling());
    }
}
