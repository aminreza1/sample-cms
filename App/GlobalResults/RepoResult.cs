namespace ContentManagementSystem.App.GlobalResults
{
    public class RepoResult
    {
        public static RepoResult Success()
        {
            return new RepoResult
            {
                IsSuccess = true,
                Details = "Done"
            };
        }
        public static RepoResult Error(string message)
        {
            return new RepoResult
            {
                IsSuccess = false,
                Details = message
            };
        }
        public bool IsSuccess { get; set; }
        public string Details { get; set; }

    }


    public class RepoResult<TData>
    {
        public static RepoResult<TData> Success(TData data)
        {
            return new RepoResult<TData>
            {
                IsSuccess = true,
                Details = "Done",
                Data = data
            };
        }
        public static RepoResult<TData> Error(string message)
        {
            return new RepoResult<TData>
            {
                IsSuccess = false,
                Details = message,
                Data = default(TData)
            };
        }
        public bool IsSuccess { get; set; }
        public string Details { get; set; }
        public TData Data { get; set; }

    }
}
