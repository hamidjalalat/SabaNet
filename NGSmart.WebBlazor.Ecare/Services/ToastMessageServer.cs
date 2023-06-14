using BlazorBootstrap;

namespace NGSmart.WebBlazor.Ecare.Services
{
    public class ToastMessageServer
    {
        public ToastMessageServer(List<ToastMessage> messages)
        {
            Messages = messages;
        }

        public List<ToastMessage> Messages { get; }

        public void ShowMessage(ToastType toastType) => Messages.Add(CreateToastMessage(toastType));

        private ToastMessage CreateToastMessage(ToastType toastType)
        => new ToastMessage
        {
            Type = toastType,
            Title = "خطای سرور",
            HelpText = $"{DateTime.Now}",
            Message = $"بر قراری ارتباط با سرور امکان پذیر نمی باشد: {DateTime.Now}",
        };
    }
}
