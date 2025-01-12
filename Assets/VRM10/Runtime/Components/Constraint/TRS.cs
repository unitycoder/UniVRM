using UnityEngine;

namespace UniVRM10
{
    struct TRS
    {
        public Vector3 Translation;
        public Quaternion Rotation;
        public Vector3 Scale;

        public static TRS GetWorld(Transform t)
        {
            return new TRS
            {
                Translation = t.position,
                Rotation = t.rotation,
                Scale = t.lossyScale,
            };
        }

        public static TRS GetLocal(Transform t)
        {
            return new TRS
            {
                Translation = t.localPosition,
                Rotation = t.localRotation,
                Scale = t.localScale,
            };
        }

        public static TRS GetRelative(Transform t, Matrix4x4 toRelative)
        {
            return new TRS
            {
                Translation = toRelative.MultiplyPoint(t.position),
                Rotation = toRelative.rotation * t.rotation,
                Scale = toRelative.MultiplyVector(t.lossyScale),
            };
        }
    }
}
