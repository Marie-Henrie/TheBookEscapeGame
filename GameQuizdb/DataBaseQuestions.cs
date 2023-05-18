namespace GameQuiz
{ 
    public class DataBaseQuestions
    {
        public int Id { get; set; }
        public int ChapterID { get; set; }
        public string Category { get; set; }
        public bool Answer { get; set; }

        public string Text { get; set; }

        public virtual Chapters? Chapters { get; set; }
    }
}
