﻿using UnityEngine;


namespace VRM
{
    public class VRMMetaObject : ScriptableObject
    {
        #region Info
        [SerializeField]
        public string Title;

        [SerializeField]
        public string Version;

        [SerializeField]
        public string Author;

        [SerializeField]
        public string ContactInformation;

        [SerializeField]
        public string Reference;

        [SerializeField]
        public Texture2D Thumbnail;
        #endregion

        #region Permission
        [SerializeField, Tooltip("A person who can perform with this avatar")]
        public AllowedUser AllowedUser;

        [SerializeField, Tooltip("Violent acts using this avatar")]
        public UssageLicense ViolentUssage;

        [SerializeField, Tooltip("Sexuality acts using this avatar")]
        public UssageLicense SexualUssage;

        [SerializeField, Tooltip("For commercial use")]
        public UssageLicense CommercialUssage;

        [SerializeField, Tooltip("Other License Url")]
        public string OtherPermissionUrl;
        #endregion

        #region Distribution License
        [SerializeField]
        public LicenseType LicenseType;

        [SerializeField]
        public string OtherLicenseUrl;
        #endregion

        /*
        public bool Equals(VRMMetaObject other)
        {
            return
            Author == other.Author
            && Title == other.Title
            && UniGLTF.MonoBehaviourComparator.AssetAreEquals(Thumbnail, other.Thumbnail)
            ;
        }
        */
    }
}