using UnityEngine;
using WORLDGAMEDEVELOPMENT;


internal sealed class CubeFactory
{
    #region Fields

    private CubeData _cubeData;
    private CubeModel _cubeModel;

    #endregion


    #region ClassLifeCycles

    public CubeFactory(CubeData cubeData)
    {
        _cubeData = cubeData;
    }

    #endregion


    #region Methods

    internal CubeModel GetCubeModel()
    {
        if (_cubeModel == null)
        {
            var cubeStruct = _cubeData.CubeStruct;
            var cubeComponents = _cubeData.CubeComponents;
            var spawnCube = Object.Instantiate(cubeStruct.Prefab);

            cubeStruct.StartPosition = spawnCube.transform.localPosition;
            cubeStruct.StartRotation = spawnCube.transform.localRotation;

            cubeComponents.CubeTransform = spawnCube.transform;

            _cubeModel = new CubeModel(cubeStruct, cubeComponents);
        }

        return _cubeModel;
    }

    #endregion
}