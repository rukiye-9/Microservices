namespace Contact.API.Infrastructure;

public interface IContactService
{
    public ContactDTO GetContId(int id)
    {
        return new ContactDTO()
        {
            ID = id,
            FirstName = "Rukiye",
            LastName = "Başboğa"
        };
    }
}