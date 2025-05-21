using System.Collections.Generic;

public class RegistrationService
{
    private List<RegistrationModel> registrationList;
    public void AddEntry(RegistrationModel registration)
    {
        if (registrationList == null)
        {
            registrationList = new List<RegistrationModel>();
        }
        registrationList.Add(registration);
    }
    public IEnumerable<RegistrationModel> Getregistrations() => registrationList;
}
