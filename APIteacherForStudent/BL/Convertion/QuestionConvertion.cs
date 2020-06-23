﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.Convertion
{
    public class QuestionConvertion
    {
        public static QuestionsDTO ConvertToDTO(Questions question)
        {
            QuestionsDTO newQuestion = new QuestionsDTO();
            newQuestion.OuestionTitle = question.OuestionTitle;
            newQuestion.ProffestionId = question.ProffestionId;
            newQuestion.QuestionContent = question.QuestionContent;
            newQuestion.QuestionId = question.QuestionId;
            newQuestion.UserId = question.UserId;
            return newQuestion;
        }
        public static Questions ConvertToQustion(QuestionsDTO questionDTO)
        {
            Questions newQuestion = new Questions();
            newQuestion.OuestionTitle = questionDTO.OuestionTitle;
            newQuestion.ProffestionId = questionDTO.ProffestionId;
            newQuestion.QuestionContent = questionDTO.QuestionContent;
            newQuestion.QuestionId = questionDTO.QuestionId;
            newQuestion.UserId = questionDTO.UserId;
            return newQuestion;
        }
        public static UserQuestionDTO ConvertToUserQuestionDTO(Questions question)
        {
            using (TeacherForStudentEntities1 db = new TeacherForStudentEntities1())
            {
                UserQuestionDTO userQuestion = new UserQuestionDTO();
                userQuestion.OuestionTitle = question.OuestionTitle;
                userQuestion.QuestionContent = question.QuestionContent;
                userQuestion.ProffestionName = (db.Proffestions.FirstOrDefault(p => p.ProffestionId == question.ProffestionId)).ProffestionName;
                User user = db.User.FirstOrDefault(u => u.UserId == question.UserId);
                userQuestion.UserKind = user.UserKind;
                userQuestion.UserMail = user.UserMail;
                userQuestion.UserName = user.UserName;
                return userQuestion;
            }

        }
    }
}
