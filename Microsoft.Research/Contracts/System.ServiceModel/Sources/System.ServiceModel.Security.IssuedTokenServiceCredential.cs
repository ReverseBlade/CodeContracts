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

// File System.ServiceModel.Security.IssuedTokenServiceCredential.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.ServiceModel.Security
{
  public partial class IssuedTokenServiceCredential
  {
    #region Methods and constructors
    internal IssuedTokenServiceCredential()
    {
    }
    #endregion

    #region Properties and indexers
    public IList<string> AllowedAudienceUris
    {
      get
      {
        return default(IList<string>);
      }
    }

    public bool AllowUntrustedRsaIssuers
    {
      get
      {
        return default(bool);
      }
      set
      {
      }
    }

    public System.IdentityModel.Selectors.AudienceUriMode AudienceUriMode
    {
      get
      {
        return default(System.IdentityModel.Selectors.AudienceUriMode);
      }
      set
      {
      }
    }

    public X509CertificateValidationMode CertificateValidationMode
    {
      get
      {
        return default(X509CertificateValidationMode);
      }
      set
      {
      }
    }

    public System.IdentityModel.Selectors.X509CertificateValidator CustomCertificateValidator
    {
      get
      {
        return default(System.IdentityModel.Selectors.X509CertificateValidator);
      }
      set
      {
      }
    }

    public IList<System.Security.Cryptography.X509Certificates.X509Certificate2> KnownCertificates
    {
      get
      {
        return default(IList<System.Security.Cryptography.X509Certificates.X509Certificate2>);
      }
    }

    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode
    {
      get
      {
        return default(System.Security.Cryptography.X509Certificates.X509RevocationMode);
      }
      set
      {
      }
    }

    public System.IdentityModel.Tokens.SamlSerializer SamlSerializer
    {
      get
      {
        return default(System.IdentityModel.Tokens.SamlSerializer);
      }
      set
      {
      }
    }

    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation
    {
      get
      {
        return default(System.Security.Cryptography.X509Certificates.StoreLocation);
      }
      set
      {
      }
    }
    #endregion
  }
}
