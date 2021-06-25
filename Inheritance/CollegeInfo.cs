using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProgram
{
    public abstract class CollegeInfo  //CollegeInformation
    {
        private string _idCard;

        public CollegeInfo(string idCard)
        {
            this._idCard = idCard;
        }
    }
    
    public class Students : CollegeInfo
    {
        #region member
        string _course;
        public void Choose() { }
        #endregion

        public Students(string course,  string idCard) : base(idCard)
        {
            this._course = course;
        }
    }
    
    public class Teachers : CollegeInfo
    {
        #region member
        string _classRoom;
        public void ManageClassRoom() { }
        public void Train() { }
        #endregion

        public Teachers(string classRoom, string idCard) : base(idCard)
        {
            this._classRoom = classRoom;
        }
    }

    public class Staff : CollegeInfo
    {
        #region member
        string _designation;
        public void Plan() { }
        public void Schedule() { }
        public void Organize() { }
        #endregion

        public Staff(string designation,string idCard) : base(idCard)
        {
            this._designation = designation;
        }
    }

    public class Guest : CollegeInfo
    {
        #region members
        string _guestSpeakers, _alumnus;
        public void Advice() { }
        #endregion

        public Guest(string guestSpeakers, string alumnus,string idCard) : base(idCard)
        {
            this._guestSpeakers = guestSpeakers;
            this._alumnus = alumnus;
        }
    }
}
