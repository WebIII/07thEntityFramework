namespace BeerhallEF.Models
{
    public class Course
    {
        #region Properties
        public int CourseId { get;private set; }
        public string Title { get; set; }
        public int? Credits { get; set; }
        public Language Language { get; set; }
        #endregion

        #region Navigational Properties
        public Brewer Brewer { get; set; }
        #endregion

        #region Constructors
        protected Course()
        {
        }

        public Course(string title, Language language, Brewer brewer)
        {
            Title = title;
            Language = language;
            Brewer = brewer;
        }
        #endregion
    }
}
