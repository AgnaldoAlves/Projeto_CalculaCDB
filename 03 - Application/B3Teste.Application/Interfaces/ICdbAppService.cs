﻿using B3Teste.Application.ViewModels;

namespace B3Teste.Application.Interfaces
{
    public interface ICdbAppService
    {
       Task<IEnumerable<CdbViewModel>> GetCalculoCDB(CdbViewModel model);

    }
}
