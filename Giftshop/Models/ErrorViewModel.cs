using System;

namespace Giftshop.Models
{
    public class ErrorViewModel
    {

        public ErrorViewModel()
        {
            CustomMessage = "Error occured while processing your request";
            ActualErrorMessage = "Please contact system admin";
        }


        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string CustomMessage { get; set; }
        public string ActualErrorMessage { get; set; }
    }
}
