using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen4Manage : MonoBehaviour
{
    GameObject buttonZubr;
    GameObject buttonPalets;
    GameObject buttonMagazin;
    GameObject button100rubley;

    float waitTime = 1f;

    void Start()
    {
        buttonZubr = GameObject.Find("ButtonZubr");
        buttonPalets = GameObject.Find("ButtonPalets");
        buttonMagazin = GameObject.Find("ButtonMagazin");
        button100rubley = GameObject.Find("Button100rubley");

        //buttonZubr.SetActive(false);
        buttonPalets.SetActive(false);
        buttonMagazin.SetActive(false);
        button100rubley.SetActive(false);

        Load2();
    }

    void Load1() { StartCoroutine(WaitAndLoad1()); }
    void Load2() { StartCoroutine(WaitAndLoad2()); }
    void Load3() { StartCoroutine(WaitAndLoad3()); }
    void Load4() { StartCoroutine(WaitAndLoad4()); }

    IEnumerator WaitAndLoad1()
    {
        yield return new WaitForSeconds(waitTime);

        buttonZubr.SetActive(true);
        buttonPalets.SetActive(false);
        buttonMagazin.SetActive(false);
        button100rubley.SetActive(false);

        Load2();
    }

    IEnumerator WaitAndLoad2()
    {
        yield return new WaitForSeconds(waitTime);

        buttonZubr.SetActive(false);
        buttonPalets.SetActive(true);
        buttonMagazin.SetActive(false);
        button100rubley.SetActive(false);

        Load3();
    }

    IEnumerator WaitAndLoad3()
    {
        yield return new WaitForSeconds(waitTime);

        buttonZubr.SetActive(false);
        buttonPalets.SetActive(false);
        buttonMagazin.SetActive(true);
        button100rubley.SetActive(false);

        Load4();
    }

    IEnumerator WaitAndLoad4()
    {
        yield return new WaitForSeconds(waitTime);

        buttonZubr.SetActive(false);
        buttonPalets.SetActive(false);
        buttonMagazin.SetActive(false);
        button100rubley.SetActive(true);

        Load1();
    }
}
