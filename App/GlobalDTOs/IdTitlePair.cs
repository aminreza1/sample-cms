namespace ContentManagementSystem.App.GlobalDTOs
{
    public class IdTitlePair<TId>
    {
        //public IdTitlePair(TId id, string title)
        //{
        //    Id = id;
        //    Title = title;
        //}

        public TId Id { get; set; }
        public string Title { get; set; }


        public static IdTitlePair<TId> Create(TId id, string title)
        {
            return new IdTitlePair<TId>
            {
                Id = id,
                Title = title
            };
        }
    }
}
