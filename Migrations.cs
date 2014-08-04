using Orchard.Data.Migration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;

namespace DeSjoerd.Competition.Theme.Widgets
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            ContentDefinitionManager.AlterTypeDefinition("HeaderTitleWidget", builder => builder
                .WithPart("CommonPart")
                .WithPart("HeaderTitlePart")
                .WithPart("WidgetPart")
                .Draftable(false)
                .Creatable(false)
                .WithSetting("Stereotype", "Widget"));

            return 1;
        }

        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterTypeDefinition("HeaderTitleWidget", builder => builder
                .WithPart("CommonPart")
                .WithPart("HeaderTitlePart")
                .WithPart("WidgetPart")
                .Draftable(false)
                .Creatable(false)
                .WithSetting("Stereotype", "Widget"));

            return 2;
        }

        public int UpdateFrom2()
        {
            ContentDefinitionManager.AlterPartDefinition("HeaderTitlePart", builder => builder
                .Attachable());

            
            return 3;
        }
    }
}