using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    #region Variáveis
    [SerializeField]
    string nameTest;

    public bool booleanTest;
    public int intTest;
    public float speed;

    public enum TestEnum {A,B,C,D}
    public TestEnum testEnum;
    public GameObject[] testGameObjects;
    public Transform target;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bom dia");
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.position, new Vector3(0.1f,0f,0f), speed * Time.deltaTime);
    }
}
