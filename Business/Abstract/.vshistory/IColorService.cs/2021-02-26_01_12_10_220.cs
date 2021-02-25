﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int ColorId);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
        
    }
}
