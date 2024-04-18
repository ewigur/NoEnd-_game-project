using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Wobble_Script : MonoBehaviour
{
    TMP_Text textMesh;

    Mesh mesh;

    Vector3[] vertices;

    public TextMeshProUGUI tmp;


    // Start is called before the first frame update
    void Start()
    {
        
        textMesh = GetComponent<TMP_Text>();
        this.tmp.fontMaterial.SetFloat(ShaderUtilities.ID_FaceDilate, -0.5f);
  
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.ForceMeshUpdate();
        mesh = textMesh.mesh;
        vertices = mesh.vertices;

        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 offset = Wobble(Time.time + i);

            vertices[i] = vertices[i] + offset;
        }

        mesh.vertices = vertices;
        textMesh.canvasRenderer.SetMesh(mesh);
    }

    Vector2 Wobble(float time)
    {
        return new Vector2(Mathf.Sin(time * 2.3f), Mathf.Cos(time * 3.5f));
    }
}

