using DeSjoerd.Competition.Theme.Widgets.Models;
using DeSjoerd.Competition.Theme.Widgets.Services;
using Orchard.ContentManagement.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeSjoerd.Competition.Theme.Widgets.Drivers
{
    public class HeaderTitlePartDriver : ContentPartDriver<HeaderTitlePart>
    {
        public HeaderTitlePartDriver()
        {
        }

        protected override DriverResult Display(HeaderTitlePart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_HeaderTitle", () => shapeHelper.Parts_HeaderTitle(HeaderTitlePart: part));
        }
    }
}