using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAnchor : MonoBehaviour
{
    public GameObject ghost;
    public GameObject cube;
    public GameObject prefab;
    
    //ghost reference
    //cube ref

    // Start is called before the first frame update
    void Start()
    {
        //find gameobject by name
        ghost = GameObject.Find("Ghost");
        cube = GameObject.Find("Cube");
        prefab = GameObject.Find("GhostAnchor");
        //ghost=GameObject.FindObjectOfType<GameObject.>
        //ghost activate
        //cube activate
        //cube.SetActive(true);
        //ghost.SetActive(true);
        MeshRenderer meshCube = cube.GetComponent<MeshRenderer>();
        meshCube.enabled = true;

        MeshRenderer meshGhost = ghost.GetComponent<MeshRenderer>();
        meshGhost.enabled = true;

        ghost.transform.position = prefab.transform.position;
        ghost.transform.rotation = prefab.transform.rotation;

        cube.transform.position = prefab.transform.position;
        cube.transform.rotation = prefab.transform.rotation;

        MeshRenderer meshPrefab = prefab.GetComponent<MeshRenderer>();
        meshPrefab.enabled = false;
        print("Code is working");
        //ghost position = transform.position
        //do rot also
        //cube activate

    }

    // Update is called once per frame
    void Update()
    {
        //ghost position = transform.position
        //do rot also
        //cube activate

        ghost.transform.position = prefab.transform.position;
        ghost.transform.rotation = prefab.transform.rotation;

        cube.transform.position = prefab.transform.position;
        cube.transform.rotation = prefab.transform.rotation;
    }

    private void OnDestroy()
    {
        //if ghost and cube ref

        //ghost deactivate
        //cube deactivate
        //cube.SetActive(false);
        //ghost.SetActive(false);
        MeshRenderer meshCube = cube.GetComponent<MeshRenderer>();
        meshCube.enabled = false;

        MeshRenderer meshGhost = ghost.GetComponent<MeshRenderer>();
        meshGhost.enabled = false;

    }
}
