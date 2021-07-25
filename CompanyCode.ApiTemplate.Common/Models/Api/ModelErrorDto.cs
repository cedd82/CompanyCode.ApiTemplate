namespace CompanyCode.ApiTemplate.Common.Models.Api
{
    public class ModelErrorDto
    {
        public ModelErrorDto(string message)
        {
            //Field = field;
            Message = message;
        }

        public string Message { get; set; }
    }
}