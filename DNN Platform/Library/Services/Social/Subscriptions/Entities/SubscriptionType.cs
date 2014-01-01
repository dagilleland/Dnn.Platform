﻿#region Copyright
// 
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2013
// by DotNetNuke Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System;

namespace DotNetNuke.Services.Social.Subscriptions.Entities
{
    /// <summary>
    /// This class represents a Subscription Type.
    /// </summary>
    [Serializable]
    public class SubscriptionType
    {
        /// <summary>
        /// The Subscription Type identifier.
        /// </summary>
        public int SubscriptionTypeId { get; set; }

        /// <summary>
        /// The Subscription Name.
        /// </summary>
        public string SubscriptionName { get; set; }

        /// <summary>
        /// The Subscription Friendly Name.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// The Desktop Module Id associated with the subscription type. 
        /// This is an optional field but it should be set if the Subscription Type belongs to a specific module.
        /// </summary>
        public int DesktopModuleId { get; set; }
    }
}
