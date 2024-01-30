using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public List<GameObject> Mocla = new List<GameObject>();
    public GameObject inv;
    public bool Activar_inv;

    //void OnTriggerEnter2D(Collider2D coll)
    //{
      //  if (coll.Comparetag("Item"))
      //  {
        //    for (int i = 0; i<Bag.Count; i++)
        //    {
          //      Bag[i].GetComponent<Image>().enabled = true;
            //    Bag[i].GetComponent<Image>().sprite = coll.GetComponent<SpriteRenderer>().sprite;
              //  break;
          //  }
        //}
    //}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Activar_inv = !Activar_inv;
        }
        else
        {
            inv.SetActive(true);
        }

        if (Activar_inv)
        {
            inv.SetActive(true);

        }
        else
        {
            inv.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Activar_inv = !Activar_inv;
        }
        else
        {
            inv.SetActive(true);
        }


    }
}
