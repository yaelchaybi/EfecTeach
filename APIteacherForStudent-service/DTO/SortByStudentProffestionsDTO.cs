﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SortByStudentProffestionsDTO
    {
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string UserKind { get; set; }
        public string ProffestionName { get; set; }
        public int QuestionId { get; set; }
        public string OuestionTitle { get; set; }
        public string QuestionContent { get; set; }
        public int UserId { get; set; }
        public int ProffestionId { get; set; }
        public System.DateTime QuestionDate { get; set; }
        public int QuestionView { get; set; }
        public int NumQuestioners { get; set; }
        public int status { get; set; }
        public Nullable<long> inc { get; set; }
    }
}
