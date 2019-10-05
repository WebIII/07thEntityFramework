namespace BeerhallEF.Models
{
    public class OnlineCourse : Course
    {
        #region Properties
        public string Url { get; set; }
        #endregion

        #region Constructors
        protected OnlineCourse()
        {
        }

        public OnlineCourse(string title, Language language, Brewer brewer, string url) : this()
        {
            Title = title;
            Language = language;
            Brewer = brewer;
            Url = url;
        }
        #endregion
    }
}

