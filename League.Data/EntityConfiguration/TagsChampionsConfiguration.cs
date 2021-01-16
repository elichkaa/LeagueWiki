namespace League.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    using Models.ChampionData;

    internal class TagsChampionsConfiguration : IEntityTypeConfiguration<TagsChampions>
    {
        public void Configure(EntityTypeBuilder<TagsChampions> builder)
        {
            builder.HasKey(x => new { x.ChampionId, x.TagId });
        }
    }
}
