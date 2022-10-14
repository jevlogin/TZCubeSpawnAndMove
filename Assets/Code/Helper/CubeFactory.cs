using UnityEngine;
using WORLDGAMEDEVELOPMENT;


internal class CubeFactory
{
    private CubeData _cubeData;
    private CubeModel _cubeModel;

    public CubeFactory(CubeData cubeData)
    {
        _cubeData = cubeData;
    }

    internal CubeModel GetCubeModel()
    {
        if (_cubeModel == null)
        {
            var cubeStruct = _cubeData.CubeStruct;
            var cubeComponents = _cubeData.CubeComponents;
            var spawnCube = Object.Instantiate(cubeStruct.Prefab);
            cubeComponents.CubeTransform = spawnCube.transform;

            _cubeModel = new CubeModel(cubeStruct, cubeComponents);
        }

        return _cubeModel;
    }
}