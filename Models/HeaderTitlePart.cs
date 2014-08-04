using Orchard.ContentManagement;
using Orchard.Core.Common.Utilities;
using Orchard.Core.Title.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeSjoerd.Competition.Theme.Widgets.Models
{
    public class HeaderTitlePart : ContentPart
    {
        internal LazyField<ContentItem> CurrentContentItemField = new LazyField<ContentItem>();

        public ContentItem CurrentContentItem
        {
            get { return CurrentContentItemField.Value; }
        }

        public TitlePart CurrentTitle { get { return CurrentContentItem != null ? CurrentContentItem.As<TitlePart>() : null; } }

        public string CurrentContentType { get { return CurrentContentItem != null ? CurrentContentItem.ContentType : null; } }
    }
}