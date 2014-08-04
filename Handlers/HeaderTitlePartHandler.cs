using DeSjoerd.Competition.Theme.Widgets.Models;
using DeSjoerd.Competition.Theme.Widgets.Services;
using Orchard.ContentManagement.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeSjoerd.Competition.Theme.Widgets.Handlers
{
    public class HeaderTitlePartHandler : ContentHandler
    {
        private readonly ICurrentContentAccessor _currentContentAccessor;

        public HeaderTitlePartHandler(ICurrentContentAccessor currentContentAccessor)
        {
			_currentContentAccessor = currentContentAccessor;
			OnActivated<HeaderTitlePart>(SetupLazyFields);
		}

        private void SetupLazyFields(ActivatedContentContext context, HeaderTitlePart part)
        {
			part.CurrentContentItemField.Loader(() => _currentContentAccessor.CurrentContentItem);
		}
    }
}