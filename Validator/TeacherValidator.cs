using SevStudentsApp.DTO;

namespace SevStudentsApp.Validator
{
    public class TeacherValidator
    {
        private TeacherValidator() { }

        public static string Validate(TeacherDTO? dto)
        {
            if ((dto!.Firstname!.Length < 3) ||
                (dto!.Lastname!.Length < 3))
            {
                return "Firstname or Lastname should not be less than thwo chars";
            }

            return "";
        }
    }
}
