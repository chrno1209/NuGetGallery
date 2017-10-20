﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Security.Principal;

namespace NuGetGallery
{
    public class ManagePackageOwnersViewModel : ListPackageItemViewModel
    {
        public bool IsCurrentUserAnAdmin;

        public ManagePackageOwnersViewModel(Package package, IPrincipal currentUser)
            : base(package)
        {
            IsCurrentUserAnAdmin = currentUser.IsAdministrator();
        }
    }
}