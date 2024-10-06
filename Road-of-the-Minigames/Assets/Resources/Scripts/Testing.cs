using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScutiUtils.Systems;

public class Testing : MonoBehaviour
{
    public int width, height;

    // Start is called before the first frame update
    void Start()
    {
        CustomGrid grid = new CustomGrid(width, height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
