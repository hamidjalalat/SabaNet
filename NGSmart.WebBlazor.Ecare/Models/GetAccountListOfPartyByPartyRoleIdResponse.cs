namespace NGSmart.WebBlazor.Ecare.Models
{
    public class AccList
    {
        public int accAccountID { get; set; }
        public int accPartyRoleID { get; set; }
        public string accAccountName { get; set; }
        public int accAccountTypeID { get; set; }
        public int accStatusID { get; set; }
        public string accUserName { get; set; }
        public string Status {
            get
            {
                switch (accStatusID)
                {
                    case 37:
                        {
                            return "فعال";
                        }
                    case 38:
                        {
                            return "غیر فعال";
                        }
                    case 6117:
                        {
                            return "معلق";
                        }
                        default:
                        {
                            return "نا مشخص";
                        }

                }
            }
        }

    }

    public class GetAccountListOfPartyByPartyRoleIdResponse
    {
        public List<AccList> accList { get; set; }
    }
}
