using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [PrimaryKey(nameof(UserId), nameof(QuizId))]
    public class UserQuiz
    {

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        [ValidateNever]
        public User User { get; set; }


        public int QuizId { get; set; }
        [ForeignKey(nameof(QuizId))]
        [ValidateNever]
        public Quiz Quiz { get; set; }
    }
}
