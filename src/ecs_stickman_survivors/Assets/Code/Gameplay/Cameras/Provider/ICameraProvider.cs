using UnityEngine;

namespace Code.Gameplay.Cameras.Provider
{
    public interface ICameraProvider
    {
        Camera MainCamera { get; }
        float WorldScreenHeight { get; }
        float WorldScreenWidth { get; }
        Vector3 CameraStartPosition { get; }
        void SetMainCamera(Camera camera);
    }
}