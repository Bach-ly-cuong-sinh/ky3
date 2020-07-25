using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlityTest1.Models
{
    class StudentsModel
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; }

        public enum StudentStatus
        {
            Deactive = 0,
            Active = 1
        }

        public StudentStatus Status { get; set; }
        public bool IsDeactive()
        {
            return Status == StudentStatus.Deactive;
        }
        public bool IsNewStudent(DateTime CreateAt)
        {
            DateTime dateNow = DateTime.Now.AddMonths(-2);
            int result = DateTime.Compare(dateNow, CreateAt);
            return result < 0;

        }
    }
}
