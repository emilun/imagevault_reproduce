using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using ImageVault.EPiServer;

namespace BugReproductionProject;

[ContentType(DisplayName = "Media Item List Block", GUID = "49DC3159-88CE-494C-9EF6-C4933007B494")]
public class MediaItemListBlock : BlockData
{
    [Display(Name = "Media Items", Order = 10)]
    [ListItemHeaderProperty(nameof(MediaItemBlock.Title))]
    public virtual IList<MediaItemBlock> MediaItems { get; set; } = [];
}

[ContentType(AvailableInEditMode = false, GUID = "223BCD2A-F372-43BD-BBF3-AD48AB487CCD")]
public class MediaItemBlock : BlockData
{
    [Display(Name = "Title", Order = 10)]
    public virtual string? Title { get; set; }

    [Display(Name = "Media", Order = 20)]
    public virtual MediaReference? Media { get; set; }
}