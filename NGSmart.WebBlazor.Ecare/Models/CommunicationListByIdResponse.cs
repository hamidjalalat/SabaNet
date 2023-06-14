namespace NGSmart.WebBlazor.Ecare.Models
{
    public record CommunicationListByIdResponse(
        long Id,
        string TypeCommunication,
        string AccountName,
        string Grouping,
        string SendTime,
        string Receiver,
        string Title,
        string Text
        );
}
