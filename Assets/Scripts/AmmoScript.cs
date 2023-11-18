using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoScript : MonoBehaviour
{
    public TMP_Text AmmoText;
    public int ammoCount = 15;
    public float nextShot;
    public float fireRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AmmoCount(int bullets)
    {
        ammoCount += bullets;
    }

    public void ShootGun()
    {
        AmmoCount(-1);
        nextShot = Time.time + fireRate;
    }

    public void UpdateAmmoText()
    {
        AmmoText.text = ammoCount.ToString();
    }
}
