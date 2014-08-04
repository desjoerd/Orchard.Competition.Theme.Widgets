using Orchard.ContentManagement;
using Orchard.Core.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace DeSjoerd.Competition.Theme.Widgets.Services
{
    /// <summary>
    /// <see cref="http://skywalkersoftwaredevelopment.net/blog/getting-the-current-content-item-in-orchard"/>
    /// </summary>
    public class CurrentContentAccessor : ICurrentContentAccessor
    {
        private readonly LazyField<ContentItem> _currentContentItemField = new LazyField<ContentItem>();
        private readonly IContentManager _contentManager;
        private readonly RequestContext _requestContext;

        public CurrentContentAccessor(IContentManager contentManager, RequestContext requestContext)
        {
            _contentManager = contentManager;
            _requestContext = requestContext;
            _currentContentItemField.Loader(GetCurrentContentItem);
        }

        public ContentItem CurrentContentItem
        {
            get { return _currentContentItemField.Value; }
        }

        private ContentItem GetCurrentContentItem()
        {
            var contentId = GetCurrentContentItemId();
            return contentId == null ? null : _contentManager.Get(contentId.Value);
        }

        private int? GetCurrentContentItemId()
        {
            object id;
            if (_requestContext.RouteData.Values.TryGetValue("id", out id))
            {
                int contentId;
                if (int.TryParse(id as string, out contentId))
                    return contentId;
            }
            return null;
        }
    }
}