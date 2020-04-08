using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button OpenBtn;
    public Button CloseBtn;

    public GameObject Browser;

    public Animator Anim;

    void Awake() {
        OpenBtn.onClick.AddListener(Open);
        CloseBtn.onClick.AddListener(Close);
    }

    void Open() {
        Browser.SetActive(true);
        Anim.Play("OpenAnim");
        CloseBtn.interactable = true;
        OpenBtn.interactable = false;
    }

    void Close()
    {
        Anim.Play("CloseAnim");
        StartCoroutine(Closing());
        CloseBtn.interactable = false;
        OpenBtn.interactable = true;
    }

    IEnumerator Closing() {
        yield return new WaitForSeconds(0.4f);
        Browser.SetActive(false);
    }
}
