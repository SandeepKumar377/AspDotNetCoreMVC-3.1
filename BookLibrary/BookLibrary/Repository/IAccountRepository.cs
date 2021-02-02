using BookLibrary.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);

        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);

        Task SignOutAsync();
    }
}