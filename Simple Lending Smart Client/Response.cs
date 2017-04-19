using System.Collections.Generic;

namespace Simple_Lending_Smart_Client
{

    class Response
    {
        public string Message { get; set; }
        public ApplicationModel Application { get; set; }
        public List<ApplicationModel> Applications { get; set; }
        public List<LenderModel> Lenders { get; set; }
        public List<UserModel> Users { get; set; }
        public string access_token { get; set; }
    }
}
