namespace Cmd.Patient.Business
{
    public class BusinessManager
    {
        Cmd.Patient.Repository.Repo repo = new Cmd.Patient.Repository.Repo();    
        public String Add()
        {
            return repo.Add();
        }

    }
}