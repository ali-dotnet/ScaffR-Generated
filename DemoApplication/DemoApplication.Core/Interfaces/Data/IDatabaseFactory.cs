#region credits
// ***********************************************************************
// Assembly	: DemoApplication.Core
// Author	: Rod Johnson
// Created	: 02-24-2013
// 
// Last Modified By : Rod Johnson
// Last Modified On : 03-18-2013
// ***********************************************************************
#endregion
namespace DemoApplication.Core.Interfaces.Data
{
    #region

    using System;

    #endregion

    public interface IDatabaseFactory : IDisposable
    {
        IDataContext Get();
    }
}