using System;

namespace IdNumber
{
    public struct SaIdentityNumber
    {
        public SaIdentityNumber(DateTime dateOfBirth, Gender gender, SaCitizen saCitizen)
        {
            _dateOfBirth = dateOfBirth;
            _gender = gender;
            _saCitizen = saCitizen;
            _id = null;
            _rnd = new Random();
            //_id = generateId();
        }

        private DateTime _dateOfBirth;
        private Gender _gender;
        private SaCitizen _saCitizen;

        private string _id;

        public string Id
        {
            get
            {
                return _id;
            }
        }


        private string _generateId()
        {
            string idNumber = _dateOfBirth.ToString("yyMMdd");
            idNumber += (int) _gender;

            int randNum = new Random().Next(1,1000);
            string random;
            if (randNum < 10) random = "00" + randNum;
            else if (randNum < 100) random = "0" + randNum;
            else random = randNum.ToString();

            idNumber += random + (int) _saCitizen + "8";
            idNumber += generateLuhnDigit(idNumber).ToString();

            return idNumber;

        }

        private Random _rnd;

        public DateTime GenerateDateOfBirth()
        {
            const int minAge = 18;
            const int maxAge = 75;
            int year = DateTime.Today.AddYears(- _rnd.Next(minAge, maxAge)).Year;
            int month = _rnd.Next(1,13);
            int lastDayOfMonth;
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    lastDayOfMonth = 30;
                    break;
                case 2:
                    lastDayOfMonth = isLeapYear(year) ? 29 : 28;
                    break;
                default:
                    lastDayOfMonth = 31;
                    break;
            }
            int day = _rnd.Next(1, lastDayOfMonth+1);
            return new DateTime(year, month, day);

        }

        private bool isLeapYear(int year)
        {
            // see https://support.microsoft.com/en-za/kb/214019 for leap year rules

            if (year%4 == 0)
            {
                if (year%100 == 0)
                {
                    if (year%400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }


        private int generateLuhnDigit(string inputString)
        {
            int total = 0;
            int count = 0;
            for (var i = 0; i < inputString.Length; i++)
            {
                int multiple = count%2 + 1;
                count++;
                int temp = multiple* int.Parse(inputString[i].ToString());
                temp = (int) Math.Floor(temp / 10.0) + (temp%10);
                total += temp;
            }
            total = (total*9) % 10;
            return total;
        }


    }
}