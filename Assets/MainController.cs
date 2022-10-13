using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using WORLDGAMEDEVELOPMENT;


public sealed class MainController : MonoBehaviour
{
    private Camera _camera;
    private Data _data;

    [SerializeField] private string _dataPath;

    private void Start()
    {
        _camera = Camera.main;
        _data = Resources.Load<Data>(Path.Combine(ManagerPath.DATA, ManagerPath.DATA));
        if (_data == null) _data = Resources.Load<Data>(_dataPath);

    }
}
