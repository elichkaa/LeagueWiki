namespace League.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models.ItemData;

    public class TagsItemsConfiguration : IEntityTypeConfiguration<TagsItems>
    {
        public void Configure(EntityTypeBuilder<TagsItems> builder)
        {
            builder.HasKey(x => new { x.ItemId, x.TagId });
        }
    }
}
