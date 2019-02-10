using System;

namespace ClassLibrary2
{
    public class Contact
    {
        string persionName, persionId, mobileNumber;
        char gender;
        int age;
        public Contact()
        { }
        public Contact(string persionname, string persionid, string mobilenumber, char gender, int age)
        {
            this.persionName = persionname;
            this.persionId = persionid;
            this.mobileNumber = mobilenumber;
            this.gender = gender;
            this.age = age;
        }
        public string PersionName
        {
            set { this.persionName = value; }
            get { return persionName; }
        }
        public string PersionId
        {
            set { this.persionId = value; }
            get { return persionId; }
        }
        public string MobileNumber
        {
            set { this.mobileNumber = value; }
            get { return mobileNumber; }
        }
        public char Gender
        {
            set { this.gender = value; }
            get { return gender; }
        }
        public int Age
        {
            set { this.age = value; }
            get { return age; }
        }
        public void ShowPersionInfo()
        {
            Console.WriteLine("Persion Name: " + persionName);
            Console.WriteLine("Persion ID: " + persionId);
            Console.WriteLine("Persion Mobile Number: " + mobileNumber);
            Console.WriteLine("Persion Gender: " + gender);
            Console.WriteLine("Persion Age: " + age);
        }
        public void DectectMobileNumber()
        {
            if(mobileNumber.CompareTo("[0-9A-Z]{2},0-9{9}"))
            {

            }
            if (mobileNumber.Length == 11)
            {
                if (mobileNumber[2].Equals('7'))
                {
                    Console.WriteLine("Gp Number.");
                }
                else if (mobileNumber[2].Equals('6'))
                {
                    Console.WriteLine("Airtel Number.");
                }
                else if (mobileNumber[2].Equals('5'))
                {
                    Console.WriteLine("Teletalk Number.");
                }
                else if (mobileNumber[2].Equals('8'))
                {
                    Console.WriteLine("Robi Number.");
                }
                else if (mobileNumber[2].Equals('9'))
                {
                    Console.WriteLine("Banglalink Number.");
                }
            }
            else if (mobileNumber.Length == 14)
            {
                if (mobileNumber[5].Equals('7'))
                {
                    Console.WriteLine("Gp Number.");
                }
                else if (mobileNumber[5].Equals('6'))
                {
                    Console.WriteLine("Airtel Number.");
                }
                else if (mobileNumber[5].Equals('5'))
                {
                    Console.WriteLine("Teletalk Number.");
                }
                else if (mobileNumber[5].Equals('8'))
                {
                    Console.WriteLine("Robi Number.");
                }
                else if (mobileNumber[5].Equals('9'))
                {
                    Console.WriteLine("Banglalink Number.");
                }
            }            
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
