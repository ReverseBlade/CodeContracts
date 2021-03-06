// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.Web.UI.UserControl.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.Web.UI
{
  public partial class UserControl : TemplateControl, IAttributeAccessor, INamingContainer, IUserControlDesignerAccessor
  {
    #region Methods and constructors
    public void DesignerInitialize ()
    {
    }

    public void InitializeAsUserControl (Page page)
    {
    }

    protected override void LoadViewState (Object savedState)
    {
    }

    public string MapPath (string virtualPath)
    {
      return default(string);
    }

    protected internal override void OnInit (EventArgs e)
    {
    }

    protected override Object SaveViewState ()
    {
      return default(Object);
    }

    string System.Web.UI.IAttributeAccessor.GetAttribute (string name)
    {
      return default(string);
    }

    void System.Web.UI.IAttributeAccessor.SetAttribute (string name, string value)
    {
    }

    public UserControl ()
    {
    }
    #endregion

    #region Properties and indexers
    public System.Web.HttpApplicationState Application
    {
      get
      {
        Contract.Ensures (Contract.Result<System.Web.HttpApplicationState>() == this.Page.Application);

        return default(System.Web.HttpApplicationState);
      }
    }

    public AttributeCollection Attributes
    {
      get
      {
        Contract.Ensures (Contract.Result<System.Web.UI.AttributeCollection>() != null);

        return default(AttributeCollection);
      }
    }

    public System.Web.Caching.Cache Cache
    {
      get
      {
        Contract.Requires (this.Page != null);
        Contract.Ensures (Contract.Result<System.Web.Caching.Cache>() != null);
        Contract.Ensures (this.Page.Cache != null);
        Contract.Ensures (Contract.Result<System.Web.Caching.Cache>() == this.Page.Cache);

        return default(System.Web.Caching.Cache);
      }
    }

    public ControlCachePolicy CachePolicy
    {
      get
      {
        Contract.Ensures (Contract.Result<System.Web.UI.ControlCachePolicy>() != null);

        return default(ControlCachePolicy);
      }
    }

    public bool IsPostBack
    {
      get
      {
        Contract.Requires (this.Page != null);
        Contract.Ensures (Contract.Result<bool>() == this.Page.IsPostBack);

        return default(bool);
      }
    }

    public System.Web.HttpRequest Request
    {
      get
      {
        Contract.Requires (this.Page != null);
        Contract.Ensures (Contract.Result<System.Web.HttpRequest>() != null);
        Contract.Ensures (this.Page.Request != null);
        Contract.Ensures (Contract.Result<System.Web.HttpRequest>() == this.Page.Request);

        return default(System.Web.HttpRequest);
      }
    }

    public System.Web.HttpResponse Response
    {
      get
      {
        Contract.Requires (this.Page != null);
        Contract.Ensures (Contract.Result<System.Web.HttpResponse>() != null);
        Contract.Ensures (this.Page.Response != null);
        Contract.Ensures (Contract.Result<System.Web.HttpResponse>() == this.Page.Response);

        return default(System.Web.HttpResponse);
      }
    }

    public System.Web.HttpServerUtility Server
    {
      get
      {
        Contract.Requires (this.Page != null);
        Contract.Ensures (Contract.Result<System.Web.HttpServerUtility>() == this.Page.Server);

        return default(System.Web.HttpServerUtility);
      }
    }

    public System.Web.SessionState.HttpSessionState Session
    {
      get
      {
        Contract.Requires (this.Page != null);
        Contract.Ensures (Contract.Result<System.Web.SessionState.HttpSessionState>() == this.Page.Session);

        return default(System.Web.SessionState.HttpSessionState);
      }
    }

    string System.Web.UI.IUserControlDesignerAccessor.InnerText
    {
      get
      {
        return default(string);
      }
      set
      {
      }
    }

    string System.Web.UI.IUserControlDesignerAccessor.TagName
    {
      get
      {
        return default(string);
      }
      set
      {
      }
    }

    public System.Web.TraceContext Trace
    {
      get
      {
        Contract.Requires (this.Page != null);
        Contract.Ensures (Contract.Result<System.Web.TraceContext>() == this.Page.Trace);

        return default(System.Web.TraceContext);
      }
    }
    #endregion
  }
}
