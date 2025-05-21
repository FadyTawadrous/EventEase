using System.Collections.Generic;

public class RegistrationService
{
    private List<RegistrationModel> registrationList;
    public void AddEntry(registrationModel registration)
    {
        if (registrationList == null)
        {
            registrationList = new List<registrationModel>();
        }
        registrationList.Add(registration);
    }
    public IEnumerable<registrationModel> Getregistrations() => registrationList;
}
