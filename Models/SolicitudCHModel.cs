using System.ComponentModel.DataAnnotations;

namespace UmbracoProject1.Models
{
    public class SolicitudCHModel
    {
        [Display(Name = "名字 ", Description = "名字 ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "请输入您的姓名")]
        [MaxLength(100, ErrorMessage = "不得超过100个字符")]
        public string Nombrech { get; set; }

        [Display(Name = "姓", Description = "姓")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "请输入您的姓氏")]
        [DataType(DataType.Text, ErrorMessage = "请输入您的姓氏")]
        [MaxLength(100, ErrorMessage = "不得超过100个字符")]
        public string Apellidoch { get; set; }

        [Display(Name = "企业", Description = "企业")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "请输入公司名称")]
        [DataType(DataType.Text, ErrorMessage = "请输入公司名称")]
        [MaxLength(100, ErrorMessage = "不得超过100个字符")]
        public string Empresach { get; set; }

        [Display(Name = "负责", Description = "负责")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "请输入您的职位")]
        [DataType(DataType.Text, ErrorMessage = "请输入您的职位")]
        [MaxLength(100, ErrorMessage = "不得超过100个字符")]
        public string Cargoch { get; set; }


        [Display(Name = "邮件 ", Description = "邮件 ")]
        [Required(ErrorMessage = "请输入您的电子邮件地址")]
        [DataType(DataType.EmailAddress, ErrorMessage = "请输入一个电子邮件地址")]
        public string Correoch { get; set; }

        [Display(Name = "电话", Description = "电话 ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "请输入您的电话号码")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "请输入一个电话号码")]
        [MaxLength(20, ErrorMessage = "请输入您的号码")]
        public string Telefonoch { get; set; }

        [Display(Name = "消息", Description = "消息")]
        [Required(ErrorMessage = "请输入您的留言")]
        [DataType(DataType.MultilineText, ErrorMessage = "请输入一条留言")]
        [MaxLength(600, ErrorMessage = "不得超过600个字符")]
        public string Mensajech { get; set; }

        [Display(Name = "ReCaptcha", Description = "ReCaptcha")]
        [Required(ErrorMessage = "请完成 reCAPTCHA 验证")]
        public string ReCaptcha { get; set; }
        public string Origench { get; set; }
    }
}
