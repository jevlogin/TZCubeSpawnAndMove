using System.IO;
using UnityEngine;
using WORLDGAMEDEVELOPMENT;


public sealed class MainController : MonoBehaviour
{
    #region Fields

    private Camera _camera;
    private Data _data;
    private Controller _controller;

    [SerializeField] private string _dataPath;

    #endregion


    #region UnityMethods

    private void Awake()
    {
        _camera = Camera.main;
        _controller = new Controller();

        _data = Resources.Load<Data>(Path.Combine(ManagerPath.DATA, ManagerPath.DATA));
        if (_data == null) _data = Resources.Load<Data>(_dataPath);

        var canvasFactory = new CanvasFactory(_data.CanvasData);
        var canvasController = new CanvasController(canvasFactory.CreateCanvasModel());

        var cubeFactory = new CubeFactory(_data.CubeData);
        var cubeController = new CubeController(cubeFactory.GetCubeModel());

        _controller.Add(cubeController);
    }

    private void Start()
    {
        _controller.Initialization();
    }

    #endregion
}
