using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidFractal : MonoBehaviour
{
    public Mesh mesh;

    public Material material;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<MeshFilter>().mesh = mesh;
        gameObject.AddComponent<MeshRenderer>().material = material;
        new GameObject("PyramidChild").AddComponent<PyramidFractal>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
