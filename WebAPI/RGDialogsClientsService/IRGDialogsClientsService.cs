namespace RGDialogsClientsService
{
    public interface IRGDialogsClientsService
    {
        List<RGDialogsClients> Init();
        Guid GetDialog(List<Guid> clientsIds);
    }
}
