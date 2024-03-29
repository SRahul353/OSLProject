﻿namespace OSLProject.Models
{
    public class QAModel
    {

            public int Id { get; set; }

            public string Title { get; set; }

            public string Content { get; set; }

            public DateTime CreatedAt { get; set; }

            public string User { get; set; }

            public List<ReplyModel> Replies { get; set; }

    }
}
