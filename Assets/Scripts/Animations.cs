using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animations : MonoBehaviour
{
    // I used a button to do the shooting, could have used a mouse button click or key press, but button is good enough.
    public Button btnShoot;

    // Making the gun appear and dissapear
    public GameObject gun;

    // The Animation Controller parameters being called
    public Animator businessAC;

    // Audio source for when he shot (timed perfectly)
    public AudioSource shotgun;
    public AudioSource deathShot;

    void Start()
    {
        Button btn = btnShoot.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    IEnumerator shootAnim()
    {
        yield return new WaitForSeconds(1.2f);
        shotgun.Play();
        yield return new WaitForSeconds(0.15f);
        deathShot.Play();
        yield return new WaitForSeconds(0.567f);
        businessAC.SetBool("ShootNow", false);
        btnShoot.gameObject.SetActive(true);
        gun.SetActive(false);
    }

    void TaskOnClick()
    {
        gun.SetActive(true);
        btnShoot.gameObject.SetActive(false);
        businessAC.SetBool("ShootNow", true);
        StartCoroutine(shootAnim());
    }
}
