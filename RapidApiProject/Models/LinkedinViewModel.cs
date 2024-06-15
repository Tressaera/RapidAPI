namespace RapidApiProject.Models
{
    public class LinkedinViewModel
    {
            public string urn { get; set; }
            public string username { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public bool isOpenToWork { get; set; }
            public bool isHiring { get; set; }
            public string profilePicture { get; set; }
            public Backgroundimage[] backgroundImage { get; set; }
            public string summary { get; set; }
            public string headline { get; set; }
            public Geo geo { get; set; }
            public Language[] languages { get; set; }
            public Education[] educations { get; set; }
            public Position[] position { get; set; }
            public Fullposition[] fullPositions { get; set; }
            public Skill[] skills { get; set; }
            public object givenRecommendation { get; set; }
            public int givenRecommendationCount { get; set; }
            public object receivedRecommendation { get; set; }
            public int receivedRecommendationCount { get; set; }
            public object courses { get; set; }
            public Certification[] certifications { get; set; }
            public object honors { get; set; }
            public Projects projects { get; set; }
            public object volunteering { get; set; }
            public Supportedlocale[] supportedLocales { get; set; }
            public Multilocalefirstname multiLocaleFirstName { get; set; }
            public Multilocalelastname multiLocaleLastName { get; set; }
            public Multilocaleheadline multiLocaleHeadline { get; set; }

        public class Geo
        {
            public string country { get; set; }
            public string city { get; set; }
            public string full { get; set; }
        }

        public class Projects
        {
            public int total { get; set; }
            public Item[] items { get; set; }
        }

        public class Item
        {
            public string title { get; set; }
            public string description { get; set; }
            public Start start { get; set; }
            public End end { get; set; }
            public Contributor[] contributors { get; set; }
        }

        public class Start
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class End
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class Contributor
        {
            public string urn { get; set; }
            public string username { get; set; }
            public string fullName { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public Profilepicture[] profilePicture { get; set; }
            public string headline { get; set; }
            public string url { get; set; }
        }

        public class Profilepicture
        {
            public int width { get; set; }
            public int height { get; set; }
            public string url { get; set; }
        }

        public class Multilocalefirstname
        {
            public string tr { get; set; }
        }

        public class Multilocalelastname
        {
            public string tr { get; set; }
        }

        public class Multilocaleheadline
        {
            public string tr { get; set; }
        }

        public class Backgroundimage
        {
            public int width { get; set; }
            public int height { get; set; }
            public string url { get; set; }
        }

        public class Language
        {
            public string name { get; set; }
            public string proficiency { get; set; }
        }

        public class Education
        {
            public Start1 start { get; set; }
            public End1 end { get; set; }
            public string fieldOfStudy { get; set; }
            public string degree { get; set; }
            public string grade { get; set; }
            public string schoolName { get; set; }
            public string description { get; set; }
            public string activities { get; set; }
            public string url { get; set; }
            public string schoolId { get; set; }
        }

        public class Start1
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class End1
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class Position
        {
            public string companyName { get; set; }
            public string companyUsername { get; set; }
            public string companyURL { get; set; }
            public string companyLogo { get; set; }
            public string companyIndustry { get; set; }
            public string companyStaffCountRange { get; set; }
            public string title { get; set; }
            public Multilocaletitle multiLocaleTitle { get; set; }
            public Multilocalecompanyname multiLocaleCompanyName { get; set; }
            public string location { get; set; }
            public string description { get; set; }
            public string employmentType { get; set; }
            public Start2 start { get; set; }
            public End2 end { get; set; }
        }

        public class Multilocaletitle
        {
            public string tr_TR { get; set; }
        }

        public class Multilocalecompanyname
        {
            public string tr_TR { get; set; }
        }

        public class Start2
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class End2
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class Fullposition
        {
            public string companyName { get; set; }
            public string companyUsername { get; set; }
            public string companyURL { get; set; }
            public string companyLogo { get; set; }
            public string companyIndustry { get; set; }
            public string companyStaffCountRange { get; set; }
            public string title { get; set; }
            public Multilocaletitle1 multiLocaleTitle { get; set; }
            public Multilocalecompanyname1 multiLocaleCompanyName { get; set; }
            public string location { get; set; }
            public string description { get; set; }
            public string employmentType { get; set; }
            public Start3 start { get; set; }
            public End3 end { get; set; }
        }

        public class Multilocaletitle1
        {
            public string tr_TR { get; set; }
        }

        public class Multilocalecompanyname1
        {
            public string tr_TR { get; set; }
        }

        public class Start3
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class End3
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class Skill
        {
            public string name { get; set; }
            public bool passedSkillAssessment { get; set; }
            public int endorsementsCount { get; set; }
        }

        public class Certification
        {
            public string name { get; set; }
            public Start4 start { get; set; }
            public End4 end { get; set; }
            public string authority { get; set; }
            public Company company { get; set; }
            public Timeperiod timePeriod { get; set; }
        }

        public class Start4
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class End4
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class Company
        {
            public string name { get; set; }
            public string universalName { get; set; }
            public string logo { get; set; }
            public Staffcountrange staffCountRange { get; set; }
            public Headquarter headquarter { get; set; }
        }

        public class Staffcountrange
        {
        }

        public class Headquarter
        {
        }

        public class Timeperiod
        {
            public Start5 start { get; set; }
            public End5 end { get; set; }
        }

        public class Start5
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class End5
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }

        public class Supportedlocale
        {
            public string country { get; set; }
            public string language { get; set; }
        }

    }
}
