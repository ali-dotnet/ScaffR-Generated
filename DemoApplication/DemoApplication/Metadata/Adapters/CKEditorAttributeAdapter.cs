#region credits
// ***********************************************************************
// Assembly	: DemoApplication
// Author	: Rod Johnson
// Created	: 03-09-2013
// 
// Last Modified By : Rod Johnson
// Last Modified On : 03-18-2013
// ***********************************************************************
#endregion
namespace DemoApplication.Metadata.Adapters
{
    #region

    using System.Collections.Generic;
    using System.Web.Mvc;
    using Attributes;
    using Rules;

    #endregion

    public class CKEditorAttributeAdapter : DataAnnotationsModelValidator<CKEditorAttribute>
    {
        public CKEditorAttributeAdapter(ModelMetadata metadata, ControllerContext context, CKEditorAttribute attribute)
            : base(metadata, context, attribute)
        {
        }

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
        {
            return new[] { new ModelClientValidationCKEditorRule(ErrorMessage) };
        }
    }
}