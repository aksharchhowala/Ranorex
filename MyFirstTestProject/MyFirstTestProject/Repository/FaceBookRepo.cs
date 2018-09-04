﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyFirstTestProject.Repository
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the FaceBookRepo element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    [RepositoryFolder("392c89e4-da42-4af2-ac93-f46b340e40a8")]
    public partial class FaceBookRepo : RepoGenBaseFolder
    {
        static FaceBookRepo instance = new FaceBookRepo();
        FaceBookRepoFolders.FacebookLogInOrSignUpAppFolder _facebookloginorsignup;

        /// <summary>
        /// Gets the singleton class instance representing the FaceBookRepo element repository.
        /// </summary>
        [RepositoryFolder("392c89e4-da42-4af2-ac93-f46b340e40a8")]
        public static FaceBookRepo Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public FaceBookRepo() 
            : base("FaceBookRepo", "/", null, 0, false, "392c89e4-da42-4af2-ac93-f46b340e40a8", ".\\RepositoryImages\\FaceBookRepo392c89e4.rximgres")
        {
            _facebookloginorsignup = new FaceBookRepoFolders.FacebookLogInOrSignUpAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("392c89e4-da42-4af2-ac93-f46b340e40a8")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FacebookLogInOrSignUp folder.
        /// </summary>
        [RepositoryFolder("1a7e5419-569e-4c3f-9903-00309ef654ea")]
        public virtual FaceBookRepoFolders.FacebookLogInOrSignUpAppFolder FacebookLogInOrSignUp
        {
            get { return _facebookloginorsignup; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    public partial class FaceBookRepoFolders
    {
        /// <summary>
        /// The FacebookLogInOrSignUpAppFolder folder.
        /// </summary>
        [RepositoryFolder("1a7e5419-569e-4c3f-9903-00309ef654ea")]
        public partial class FacebookLogInOrSignUpAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _txt_emailInfo;
            RepoItemInfo _txt_passwordInfo;
            RepoItemInfo _btn_loginInfo;

            /// <summary>
            /// Creates a new FacebookLogInOrSignUp  folder.
            /// </summary>
            public FacebookLogInOrSignUpAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FacebookLogInOrSignUp", "/dom[@domain='www.facebook.com']", parentFolder, 30000, null, false, "1a7e5419-569e-4c3f-9903-00309ef654ea", "")
            {
                _txt_emailInfo = new RepoItemInfo(this, "txt_Email", ".//input[#'email']", 30000, null, "78255b98-2eb6-4081-a03a-afaef4327775");
                _txt_passwordInfo = new RepoItemInfo(this, "txt_Password", ".//input[#'pass']", 30000, null, "4d839bd1-451a-4767-8c66-e42d6cfd8d80");
                _btn_loginInfo = new RepoItemInfo(this, "btn_LogIn", ".//label[#'loginbutton']", 30000, null, "e46d4ec2-698c-4ac7-9d0f-4d68514b7f5e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1a7e5419-569e-4c3f-9903-00309ef654ea")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1a7e5419-569e-4c3f-9903-00309ef654ea")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The txt_Email item.
            /// </summary>
            [RepositoryItem("78255b98-2eb6-4081-a03a-afaef4327775")]
            public virtual Ranorex.InputTag txt_Email
            {
                get
                {
                    return _txt_emailInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The txt_Email item info.
            /// </summary>
            [RepositoryItemInfo("78255b98-2eb6-4081-a03a-afaef4327775")]
            public virtual RepoItemInfo txt_EmailInfo
            {
                get
                {
                    return _txt_emailInfo;
                }
            }

            /// <summary>
            /// The txt_Password item.
            /// </summary>
            [RepositoryItem("4d839bd1-451a-4767-8c66-e42d6cfd8d80")]
            public virtual Ranorex.InputTag txt_Password
            {
                get
                {
                    return _txt_passwordInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The txt_Password item info.
            /// </summary>
            [RepositoryItemInfo("4d839bd1-451a-4767-8c66-e42d6cfd8d80")]
            public virtual RepoItemInfo txt_PasswordInfo
            {
                get
                {
                    return _txt_passwordInfo;
                }
            }

            /// <summary>
            /// The btn_LogIn item.
            /// </summary>
            [RepositoryItem("e46d4ec2-698c-4ac7-9d0f-4d68514b7f5e")]
            public virtual Ranorex.LabelTag btn_LogIn
            {
                get
                {
                    return _btn_loginInfo.CreateAdapter<Ranorex.LabelTag>(true);
                }
            }

            /// <summary>
            /// The btn_LogIn item info.
            /// </summary>
            [RepositoryItemInfo("e46d4ec2-698c-4ac7-9d0f-4d68514b7f5e")]
            public virtual RepoItemInfo btn_LogInInfo
            {
                get
                {
                    return _btn_loginInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}