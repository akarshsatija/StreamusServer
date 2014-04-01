using FluentValidation;

namespace Streamus_Web_API.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            //  Max length of 50 is just a precaution. Could probably get away with 21, but giving room for growth.
            RuleFor(user => user.GooglePlusId).NotNull().Length(0, 30);
        }
    }
}