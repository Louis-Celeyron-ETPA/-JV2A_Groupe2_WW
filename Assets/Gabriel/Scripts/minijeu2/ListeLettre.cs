using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class ListeLettre : MonoBehaviour
    {
        public List<int> couleurLettre = new List<int>();
        public List<MesLettres> listeDesLettres = new List<MesLettres>();

        [SerializeField]
        private List<Material> textureDispo = new List<Material>();

        public int nombreLettre;

        [SerializeField]
        private MesLettres maLettre;
        // Start is called before the first frame update
        void Start()
        {
            nombreLettre += 2 * ManagerManager.DifficultyManager.GetDifficulty();

            for (int i = 0; i < nombreLettre; i++)
            {
                int colorPick = Random.Range(0, 4);

                couleurLettre.Add(colorPick);

                MesLettres lettreCree = Instantiate(maLettre, new Vector3(-10 + (i * 2), -4, -13), Quaternion.identity);

                lettreCree.transform.rotation = Quaternion.Euler(0, 180, 0);
                lettreCree.mr.material = textureDispo[colorPick];
                listeDesLettres.Add(lettreCree);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
