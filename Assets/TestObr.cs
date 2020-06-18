using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TestObr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Observable.Range(1, 5)
                .Scan(100, (x , y) => x + y)
                .Subscribe(x =>
                {
                    Debug.Log(x);
                });
    }
}
