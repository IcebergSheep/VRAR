using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    public GameObject bulletFactory;
    public GameObject firePosition;

    public int poolSize = 10;
    public List<GameObject> bulletObjectPool;
    // Start is called before the first frame update
    void Start()
    {
        bulletObjectPool = new List<GameObject>();
        for(int i = 0; i< poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletFactory);
            bulletObjectPool.Add(bullet);
            bullet.SetActive(false);
        }
#if UNITY_ANDROID
        GameObject.Find("Joystick canvas XYBZ").SetActive(true);
#elif UNITY_EDITOR || UNITY_STANDLONE
        GameObject.Find("Joystick canvas XYBZ").SetActive(false);
#endif
    }


    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDLONE
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
#endif
    }

    public void Fire()
    {
        if (bulletObjectPool.Count > 0)
        {
            GameObject bullet = bulletObjectPool[0];
            bulletObjectPool.Remove(bullet);
            bullet.transform.position = firePosition.transform.position;
            bullet.SetActive(true);
        }

    }

    //    if (Input.GetButton("Fire1"))
    //    {
    //        //for(int i = 0; i<poolSize; i++)
    //        //{
    //        //    GameObject bullet = Instantiate(bulletFactory);
    //        //    if(bullet.activeSelf == false)
    //        //    {
    //        //        bullet.SetActive(true);
    //        //        bullet.transform.position = firePosition.transform.position;
    //        //        break;
    //        //    }
    //        //}
    //        if(bulletObjectPool.Count > 0)
    //        {
    //            GameObject bullet = bulletObjectPool[0];
    //            bulletObjectPool.Remove(bullet);
    //            bullet.transform.position = firePosition.transform.position;
    //            bullet.SetActive(true);
    //        }

    //    }
    //}


}
