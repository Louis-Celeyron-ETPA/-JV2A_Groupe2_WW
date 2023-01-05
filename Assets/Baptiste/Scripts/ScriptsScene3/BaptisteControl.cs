using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Baptiste;

namespace Baptiste
{

    public class BaptisteControl : MonoBehaviour
    {
        private GameObject newObject;

        public TMP_Text textAmmo;
        public int ammo;
        public float currentTime;
        public float lastFired;
        public List<GameObject> projectileList;
        public GameObject MargoulinProj;
        public Scene3MainScript scene3MainScript;
        private int rm;
        // Start is called before the first frame update
        void Start()
        {
            lastFired = 0;
            projectileList = new List<GameObject>();
            rm = -1;
        }

        // Update is called once per frame
        void Update()
        {
            ammo = scene3MainScript.ammo;
            currentTime += Time.deltaTime;

            if (rm != -1)
            {
                projectileList.RemoveAt(rm);
                rm = -1;
            }

            foreach (GameObject item in projectileList)
            {
                if (item != null)
                {
                    item.transform.position += Vector3.right * 0.2f;
                    if (item.transform.position.x > 10)
                    {
                        rm = projectileList.IndexOf(item);
                        Destroy(item);
                    }
                }
            }
        }

        public void BaptisteUp()
        {
            if (transform.position.y < 5.7f)
            {
                transform.position += Vector3.up * 0.2f; ;
            }
        }

        public void BaptisteDown()
        {
            if (transform.position.y > -3.7f)
            {
                transform.position -= Vector3.up * 0.2f;
            }
        }

        public void FireMargoulin()
        {
            if (currentTime - lastFired > 0.3f && ammo > 0)
            {
                scene3MainScript.ammo -= 1;
                newObject = Instantiate(MargoulinProj, new Vector3(-7.5f, transform.position.y, 0), Quaternion.identity);
                projectileList.Add(newObject);
                lastFired = currentTime;
                textAmmo.text = "x" + (ammo - 1);
            }
        }
    }
}