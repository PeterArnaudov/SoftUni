namespace MilitaryElite.Interfaces
{
    using MilitaryElite.Classes;
    using System;
    using System.Collections.Generic;

    public interface ILieutenantGeneral : IPrivate
    {
        List<Private> Privates { get; }
    }
}
