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
    /// The class representing the Amazon_Repo element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    [RepositoryFolder("54894421-98c9-40c2-8bbd-3eaa77816017")]
    public partial class Amazon_Repo : RepoGenBaseFolder
    {
        static Amazon_Repo instance = new Amazon_Repo();
        Amazon_RepoFolders.AmazonComOnlineShoppingForElectronAppFolder _amazoncomonlineshoppingforelectron;

        /// <summary>
        /// Gets the singleton class instance representing the Amazon_Repo element repository.
        /// </summary>
        [RepositoryFolder("54894421-98c9-40c2-8bbd-3eaa77816017")]
        public static Amazon_Repo Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Amazon_Repo() 
            : base("Amazon_Repo", "/", null, 0, false, "54894421-98c9-40c2-8bbd-3eaa77816017", ".\\RepositoryImages\\Amazon_Repo54894421.rximgres")
        {
            _amazoncomonlineshoppingforelectron = new Amazon_RepoFolders.AmazonComOnlineShoppingForElectronAppFolder(this);
        }

#region Variables

        string _strLoginLink = "nav-link-accountList";

        /// <summary>
        /// Gets or sets the value of variable strLoginLink.
        /// </summary>
        [TestVariable("8aa6feb7-aeca-40d7-82fc-cd095ca9b97e")]
        public string strLoginLink
        {
            get { return _strLoginLink; }
            set { _strLoginLink = value; }
        }

        string _strWebAddress = "www.amazon.com";

        /// <summary>
        /// Gets or sets the value of variable strWebAddress.
        /// </summary>
        [TestVariable("170effa9-de9d-4ffe-aac6-d6a0137cf229")]
        public string strWebAddress
        {
            get { return _strWebAddress; }
            set { _strWebAddress = value; }
        }

        string _strLoginId = "nav-link-yourAccount";

        /// <summary>
        /// Gets or sets the value of variable strLoginId.
        /// </summary>
        [TestVariable("0f744b69-af28-41ed-b1d9-02189d70f132")]
        public string strLoginId
        {
            get { return _strLoginId; }
            set { _strLoginId = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("54894421-98c9-40c2-8bbd-3eaa77816017")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The AmazonComOnlineShoppingForElectron folder.
        /// </summary>
        [RepositoryFolder("f7541bf3-b009-4c72-9034-720ad19a1126")]
        public virtual Amazon_RepoFolders.AmazonComOnlineShoppingForElectronAppFolder AmazonComOnlineShoppingForElectron
        {
            get { return _amazoncomonlineshoppingforelectron; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    public partial class Amazon_RepoFolders
    {
        /// <summary>
        /// The AmazonComOnlineShoppingForElectronAppFolder folder.
        /// </summary>
        [RepositoryFolder("f7541bf3-b009-4c72-9034-720ad19a1126")]
        public partial class AmazonComOnlineShoppingForElectronAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _link_loginInfo;
            RepoItemInfo _txt_usernameInfo;
            RepoItemInfo _btn_continueInfo;
            RepoItemInfo _txt_searchbarInfo;

            /// <summary>
            /// Creates a new AmazonComOnlineShoppingForElectron  folder.
            /// </summary>
            public AmazonComOnlineShoppingForElectronAppFolder(RepoGenBaseFolder parentFolder) :
                    base("AmazonComOnlineShoppingForElectron", "/dom[@domain=$strWebAddress]", parentFolder, 30000, null, false, "f7541bf3-b009-4c72-9034-720ad19a1126", "")
            {
                _link_loginInfo = new RepoItemInfo(this, "link_Login", ".//a[#$strLoginId]", 30000, null, "ece87dec-52a6-4c23-aec5-00016d3d1eab");
                _txt_usernameInfo = new RepoItemInfo(this, "txt_UserName", ".//input[#'ap_email']", 30000, null, "b910b2a7-bb26-458f-88e4-c2bdf2bcc6a2");
                _btn_continueInfo = new RepoItemInfo(this, "btn_Continue", ".//span[#'continue']/?/?/input[@id='continue']", 30000, null, "6fc068c2-d2ba-44a6-aa0b-77514fe938f3");
                _txt_searchbarInfo = new RepoItemInfo(this, "txt_SearchBar", ".//input[#'twotabsearchtextbox']", 30000, null, "c6ab7376-458e-4175-83a2-064ff566097d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f7541bf3-b009-4c72-9034-720ad19a1126")]
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
            [RepositoryItemInfo("f7541bf3-b009-4c72-9034-720ad19a1126")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The link_Login item.
            /// </summary>
            [RepositoryItem("ece87dec-52a6-4c23-aec5-00016d3d1eab")]
            public virtual Ranorex.ATag link_Login
            {
                get
                {
                    return _link_loginInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The link_Login item info.
            /// </summary>
            [RepositoryItemInfo("ece87dec-52a6-4c23-aec5-00016d3d1eab")]
            public virtual RepoItemInfo link_LoginInfo
            {
                get
                {
                    return _link_loginInfo;
                }
            }

            /// <summary>
            /// The txt_UserName item.
            /// </summary>
            [RepositoryItem("b910b2a7-bb26-458f-88e4-c2bdf2bcc6a2")]
            public virtual Ranorex.InputTag txt_UserName
            {
                get
                {
                    return _txt_usernameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The txt_UserName item info.
            /// </summary>
            [RepositoryItemInfo("b910b2a7-bb26-458f-88e4-c2bdf2bcc6a2")]
            public virtual RepoItemInfo txt_UserNameInfo
            {
                get
                {
                    return _txt_usernameInfo;
                }
            }

            /// <summary>
            /// The btn_Continue item.
            /// </summary>
            [RepositoryItem("6fc068c2-d2ba-44a6-aa0b-77514fe938f3")]
            public virtual Ranorex.InputTag btn_Continue
            {
                get
                {
                    return _btn_continueInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The btn_Continue item info.
            /// </summary>
            [RepositoryItemInfo("6fc068c2-d2ba-44a6-aa0b-77514fe938f3")]
            public virtual RepoItemInfo btn_ContinueInfo
            {
                get
                {
                    return _btn_continueInfo;
                }
            }

            /// <summary>
            /// The txt_SearchBar item.
            /// </summary>
            [RepositoryItem("c6ab7376-458e-4175-83a2-064ff566097d")]
            public virtual Ranorex.InputTag txt_SearchBar
            {
                get
                {
                    return _txt_searchbarInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The txt_SearchBar item info.
            /// </summary>
            [RepositoryItemInfo("c6ab7376-458e-4175-83a2-064ff566097d")]
            public virtual RepoItemInfo txt_SearchBarInfo
            {
                get
                {
                    return _txt_searchbarInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}