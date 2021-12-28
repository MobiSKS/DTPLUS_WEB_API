using HPCL.DataModel.Account;

namespace HPCL.DataRepository.Account
{
    public interface IAccountRepository
    {
        public bool GenerateToken(AccountModel ObjUser);
    }
}
