using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    public Dictionary<weapon, int> Ammo = new Dictionary<weapon, int>();
    public enum weapon {Pistol, SMG, Assault };
    public weapon Cweapon;
    public int Ammo_left;
    // Start is called before the first frame update
    void Start()
    {
        Ammo.Add(weapon.Pistol, 100);
        Ammo.Add(weapon.SMG, 200);
        Ammo.Add(weapon.Assault, 150);
    }

    // Update is called once per frame
    void Update()
    {
        Ammo_left = Ammo[Cweapon];
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Cweapon == weapon.Pistol)
            {
                Cweapon = weapon.SMG;
            }
            else
            {
                if (Cweapon == weapon.SMG)
                {
                    Cweapon = weapon.Assault;
                }
                else
                {
                    if (Cweapon == weapon.Assault)
                    {
                        Cweapon = weapon.Pistol;
                    }
                }
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (Cweapon == weapon.Pistol)
            {
                Debug.Log("Pistol: "+Ammo[weapon.Pistol]);
                Ammo[weapon.Pistol] = Ammo[weapon.Pistol] -= 1;
            }
            else
            {
                if (Cweapon == weapon.SMG)
                {
                    Debug.Log("SMG: " + Ammo[weapon.SMG]);
                    Ammo[weapon.SMG] = Ammo[weapon.SMG] -= 1;
                } else
                {
                    if (Cweapon == weapon.Assault)
                    {
                        Debug.Log("Assault: " + Ammo[weapon.Assault]);
                        Ammo[weapon.Assault] = Ammo[weapon.Assault] -= 1;
                    }
                }
            }
        }
    }
}
