using WORLDGAMEDEVELOPMENT;

internal sealed class CubeModel
{
    public CubeStruct CubeStruct;
    public CubeComponents CubeComponents;

    public CubeModel(CubeStruct cubeStruct, CubeComponents cubeComponents)
    {
        CubeStruct = cubeStruct;
        CubeComponents = cubeComponents;
    }
}