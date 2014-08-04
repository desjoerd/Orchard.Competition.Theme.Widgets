using Orchard;
using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeSjoerd.Competition.Theme.Widgets.Services
{
    /// <summary>
    /// <see cref="http://skywalkersoftwaredevelopment.net/blog/getting-the-current-content-item-in-orchard"/>
    /// </summary>
    public interface ICurrentContentAccessor : IDependency
    {
        ContentItem CurrentContentItem { get; }
    }
}