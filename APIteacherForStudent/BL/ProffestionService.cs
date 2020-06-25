﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL
{
    public class ProffestionService
    {
        public static List<ProffestionsDTO> GetAllQuestions()
        {
            List<ProffestionsDTO> proffestions = new List<ProffestionsDTO>();
            using (TeacherForStudentEntities db=new TeacherForStudentEntities())
            {
                db.Proffestions.ToList().ForEach(pro => 
                proffestions.Add(Convertion.ProffestionConvertion.ConvertToDTO(pro)));
            }
            return proffestions;
        }
    }
}